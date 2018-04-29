using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedTest
{
    class Article
    {
        private UInt64 artnum;
        private string messageid;

        public UInt64 id
        {
            get { return artnum; }
        }

        public string MessageId
        {
            get { return messageid; }
        }

        public Article(UInt64 i, string m)
        {
            artnum = i;
            messageid = m;
        }

        // expected is a line returned from XOVER command
        public Article(string line)
        {
            string[] s = line.Split('\t');
            artnum = Convert.ToUInt64(s[0]);
            //subject = s[1];
            //from = s[2];
            //datum = s[3];
            messageid = s[4];
            //references = s[5];
            //bytes = s[6];
            //lines = s[7];
        }

        public string GetCommand(string cmd, EArticleMethod meth)
        {
            if (meth == EArticleMethod.Numeric)
                return cmd + " " + id + "\r\n";
            else
                return cmd + " " + MessageId + "\r\n";
        }


    }
}
