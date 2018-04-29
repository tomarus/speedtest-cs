// file: NNTP.cs

using System;
using System.Collections;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace SpeedTest {


public class StatusEventArgs : EventArgs
{
	private string status;

	public StatusEventArgs(string message)
	{
		status = message;
	}

	public string Status
	{
		get 
		{
			return status;
		}

	}
}

public delegate void StatusEventHandler(object sender, StatusEventArgs e);

public class StatusListener
{
    private NNTPClient nc;

    public StatusListener(NNTPClient ncl)
    {
        nc = ncl;
        nc.StatusMessage += new StatusEventHandler(ListChanged);
    }

    private void ListChanged(object sender, StatusEventArgs e)
    {
        Console.Write(e.Status);
    }

    public void Detach()
    {
        nc.StatusMessage -= new StatusEventHandler(ListChanged);
        nc = null;
    }
}
} // namespace
