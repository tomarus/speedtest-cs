using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace SpeedTest
{
    public class NntpException : System.ApplicationException
    {
        public NntpException(string str) : base(str)
        {
        }
    }

    public class NNTP : System.Net.Sockets.TcpClient
    {
        private string hostname;
        private int port = 119;

        private bool postingallowed;
        private string response;                    // last response

        public void Connect(string server)
        {
            hostname = server;

            Connect(hostname, port);
            //response = base.Resp
            if (response.StartsWith("200"))
            {
                postingallowed = true;
            }
            else if (response.StartsWith("201"))
            {
                postingallowed = false;
            }
            else
            {
                throw new NntpException(response);
            }
        }
    }
}
