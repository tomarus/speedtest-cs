// file: main.cs

using System;
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

using SpeedTest;


public class OVTest
{
	private NNTPClient nc;
	private StatusListener status;
    private static Form1 form;
    private static LogForm logform;

	public static void Main (string[] args)
	{
        string v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        //Application.Run(new Form1());
        form = new Form1();
        logform = new LogForm();
        form.logform = logform;
        logform.Show();

        form.Statusbar = "Ready..";
        form.Text = "Usenet Speedtest "+v;

        Application.Run(form);
	}

	public OVTest()
	{
		nc = new NNTPClient();
      	status = new StatusListener(nc);
        logform.SetLogHandler(nc);

        form.SetLatencyArticles("0 ms");
        form.SetSpeedArticles("0 kbps");
        form.SetSpeedXover("0 kbps");

        if (connect() == false)
            return;

        form.Statusbar = "Joining group";
        if (nc.Group(form.Newsgroup) == false)
        {
            form.Statusbar = nc.Response;
            return;
        }

        Thread newThread = new Thread(new ThreadStart(doovtests));
        newThread.Start();
    }

    private bool connect()
    {
        if (nc.Connect(form.Hostname) == false)
        {
            form.Statusbar = nc.Response;
            return false;
        }

        if (form.Username.Length > 0)
        {
            form.Statusbar = "Authenticating";
            if (nc.AuthInfo(form.Username, form.Password) == false)
                return false;
        }

        return true;
    }

    private void dotest_xover()
    {
        UInt64 maxarts = form.ArtsXover;
        EArticleAge artage = form.ArtAge;

        form.SetProgress((maxarts / 1000)+1);
        nc.form = form;

        ulong start = nc.groupstart;
        ulong end = nc.groupend;

        if (maxarts == 0) 
		{
            nc.Xover(0, 0);
            return;
        }

        if ( artage == EArticleAge.New )
        {
            start = end - maxarts;
        }
        else if ( artage == EArticleAge.Old )
        {
            end = start + maxarts;
        }
        else if ( artage == EArticleAge.Random )
        {
            ulong mid = start + ( (end - start) / 2 );
            start = mid;
            end = mid + maxarts;
        }

		nc.Xover(start, end);
    }

    private void dotest_stat()
    {
        form.SetProgress(form.ArtsArticles);
        nc.CheckLatency((int)form.ArtsArticles);
    }

    private void dotest_article()
    {
        form.SetProgress(form.ArtsArticles);
        nc.CheckArticles((int)form.ArtsArticles);
    }

    private void doovtests()
    {
        dotest_xover();

        logform.AppendText("Speedtest Starting");
        form.Statusbar = "Reconnecting..";
        nc.Close();
        connect();

        form.Statusbar = "Connected..";
        if (form.JoinGroup == true || form.ArtMethod == EArticleMethod.Numeric)
        {
            form.Statusbar = "Joining group";
            if (nc.Group(form.Newsgroup) == false)
            {
                form.Statusbar = nc.Response;
                return;
            }
        }
        form.Statusbar = "Initializing STAT test";
        dotest_stat();
        dotest_article();

        form.SetProgress(1);
        form.Statusbar = "Done";
		nc.Close();
		status.Detach();
	}

}

