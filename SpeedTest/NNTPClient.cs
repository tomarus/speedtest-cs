using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using System.Text;
using SpeedTest;

public enum EArticleAge
{
    New, Old, Random
}

public enum EArticleMethod
{
    Numeric, Messageid
}

public enum EArticleCommand
{
    BODY, HEAD, ARTICLE
}

public class NNTPClient
{
	TcpClient	    client;
	NetworkStream	ns;
	StreamReader	reader;
	StreamWriter	writer;
    public Form1 form;

	private string	last_response	= "";
	private int	    connected	= 0;

	public string	group		= "";
	public long	    grouparts	= 0;
	public UInt64	groupstart	= 0;
	public UInt64	groupend	= 0;

	ArrayList	    articles	= new ArrayList();
	public int	    xpatnumres	= 0;
	public int	    xovernumres	= 0;

    public event StatusEventHandler StatusMessage;

	protected virtual void LogMessage(string msg) 
	{
		StatusEventArgs e = new StatusEventArgs(msg);
		if (StatusMessage != null)
			StatusMessage(this, e);
	}
	
	public string Response 
	{
		get
		{
			return last_response;
		}
	}

	public bool Connect(String hostname)
	{
		if ( connected == 1 )
			return true;

		try {
			client = new TcpClient(hostname, 119);
			client.SendTimeout = 5;

			ns = client.GetStream();
            reader = new StreamReader(ns, System.Text.Encoding.ASCII);
			writer = new StreamWriter(ns);

			last_response = reader.ReadLine();
			if ( ! last_response.StartsWith("200") && ! last_response.StartsWith("201") )
			{
				LogMessage("Invalid response from server: " + last_response);
				client.Close();
				return false;
			}
		}
		catch (SocketException ex) 
		{
            LogMessage("Error connecting to server " + hostname + ": " + ex.Message);
			return false;
		}

        LogMessage(last_response);
		connected++;
		return true;
	}

    public bool AuthInfo(string Username, string Password)
    {
        string res;

        try
        {
            writer.WriteLine("AUTHINFO USER " + Username + "\r\n");
            writer.Flush();
            res = reader.ReadLine();

            writer.WriteLine("AUTHINFO PASS " + Password + "\r\n");
            writer.Flush();
            res = reader.ReadLine();
        }
        catch (SocketException ex)
        {
            LogMessage("Error authenticating:" + ex.Message);
            return false;
        }

        LogMessage(res);
        if (!res.StartsWith("281"))
        {
            return false;
        }

        LogMessage("Successfully authenticated");
        return true;
    }

	public void Close()
	{
		if ( connected == 1 )
		{
            connected = 0;
			writer.WriteLine("QUIT\r\n");
			writer.Flush();
			reader.ReadLine();
			client.Close();
            LogMessage("Disconnected");
		}
	}

	public bool Group(string newgroup)
	{
		if ( newgroup.Length == 0 ) return false;

        try
        {
            LogMessage("GROUP "+newgroup);
            writer.WriteLine("GROUP " + newgroup + "\r\n");
            writer.Flush();

            last_response = reader.ReadLine();
        }
        catch (SocketException ex)
        {
            LogMessage("Error setting group:" + ex.Message);
            return false;
        }

        if (!last_response.StartsWith("211"))
        {
            LogMessage("GROUP command failed: " + last_response);
            return false;
        }

        LogMessage(last_response);
		string[] numpos = last_response.Split(' ');

		grouparts  = Convert.ToInt64(numpos[1]);
		groupstart = Convert.ToUInt64(numpos[2]);
		groupend   = Convert.ToUInt64(numpos[3]);
		group = numpos[4].Trim("\r\n".ToCharArray());

		return true;
	}

    private int CheckArticle(Article art)
    {
        string cmd = art.GetCommand(form.ArtCommand.ToString(), form.ArtMethod);

        writer.WriteLine(cmd);
        writer.Flush();
        int s = 0;

        last_response = reader.ReadLine();
        if (!last_response.StartsWith("2"))
        {
            LogMessage(cmd + " command failed: " + last_response);
            return 0;
        }

        string l;
        do
        {
            l = reader.ReadLine();
            s += l.Length;
        } while (l != ".");

        return s;
    }

    public void CheckArticles(int max)
    {
        ulong totsize = 0;
        DateTime starttime = DateTime.Now;

        int arts = 0;

        foreach (Article a in articles)
        {
            ulong s = (ulong)CheckArticle(a);
            totsize += s;

            printatimings(starttime, totsize);
            arts++;
            if (arts > max) break;
        }
    }

    private bool CheckStat(Article art)
    {
        string cmd = art.GetCommand("STAT", form.ArtMethod);

        writer.WriteLine(cmd + "\r\n");
        writer.Flush();

        last_response = reader.ReadLine();
        if (!last_response.StartsWith("2"))
        {
            LogMessage("STAT command failed: " + last_response);
            return false;
        }

        return true;
    }

    public void CheckLatency(int max)
    {
        DateTime starttime = DateTime.Now;

        int arts = 0;

        // check on article numbers
        foreach (Article a in articles)
        {
            CheckStat(a);
            printstimings(starttime, arts);

            arts++;
            if (arts > max) break;
        }
    }

	public bool Xover(UInt64 start, UInt64 end)
	{
        ArrayList overdata = new ArrayList();

		if ( start == 0 ) start = groupstart;
		if ( end   == 0 ) end   = groupend;

        string cmd = "XOVER " + start + "-" + end + "\r\n";
        LogMessage(cmd);
		writer.WriteLine(cmd);
		writer.Flush();

		last_response = reader.ReadLine();
		if ( ! last_response.StartsWith("224") )
		{
            LogMessage("XOVER command failed: " + last_response);
			form.Statusbar = "XOVER command failed: " + last_response;
			return false;
		}

        DateTime starttime = DateTime.Now;
		string line;
        ulong size = 0;
		do {
			line = reader.ReadLine();

			if ( line != "." )
			{
                size += (ulong)line.Length;

                if ( (ulong)articles.Count < form.ArtsArticles )
                    articles.Add(new Article(line));

        	    xovernumres++;
                if (xovernumres % 1000 == 0)
                    printtimings(starttime, size);
			}
		} while (line != "." );
		
        printtimings(starttime, size);
        LogMessage("Got " + xovernumres + " XOVER results");
		return true;
	}

    private string formatbytes(UInt64 b)
    {
        UInt64 kb = 1000;
        UInt64 mb = kb * 1000;
        UInt64 gb = mb * 1000;

        string res;
        if (b > gb)
            res = String.Format("{0:F} gb", (float)b / gb);
        else if (b > mb)
            res = String.Format("{0:F} mb", (float)b / mb);
        else if (b > kb)
            res = String.Format("{0:F} kb", (float)b / kb);
        else
            res = String.Format("{0:D} b", b);

        return res;
    }

    private ulong getmsecs(DateTime starttime)
    {
        DateTime endtime = DateTime.Now;
        TimeSpan span = endtime - starttime;
        ulong msecs = (ulong)span.TotalMilliseconds;
        if (msecs == 0) msecs = 1;
        return msecs;
    }


    void printatimings(DateTime starttime, ulong size)
    {
        ulong msecs = getmsecs(starttime);
        ulong kbps = (size / msecs);

        form.Statusbar = form.ArtCommand + ": " + formatbytes(size) + " in " + msecs/1000 + " secs, " + kbps + " kbps";
        form.DoProgress();
        form.SetSpeedArticles(kbps + " kbps");
    }

    void printstimings(DateTime starttime, int arts)
    {
        ulong msecs = getmsecs(starttime);
        if (arts == 0) arts = 1;
        ulong ms = msecs / (ulong)arts;

        form.Statusbar = "STAT: " + arts + " arts in " + msecs/1000 + " secs, " + ms + " ms";
        form.DoProgress();
        form.SetLatencyArticles(ms + " ms");
    }

    void printtimings(DateTime starttime, ulong size)
    {
        ulong msecs = getmsecs(starttime);
        ulong kbps = (size / msecs);

        form.Statusbar = "XOVER: " + xovernumres + " in " + msecs/1000 + " secs, " + kbps + " kbps";
        form.DoProgress();
        form.SetSpeedXover(kbps + " kbps");
    }
}
