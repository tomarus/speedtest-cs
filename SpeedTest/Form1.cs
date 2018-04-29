using System;
using System.Windows.Forms;

namespace SpeedTest
{
    public partial class Form1 : Form
    {
        public LogForm logform;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Statusbar = "Initializing";
            new OVTest();
        }

        public string Username
        {
            get
            {
                return tbUsername.Text.ToString();
            }
        }

        public string Password
        {
            get
            {
                return tbPassword.Text.ToString();
            }
        }
        public string Hostname
        {
            get
            {
                return tbHostname.Text.ToString();
            }
        }
        public string Newsgroup
        {
            get
            {
                return tbNewsgroup.Text.ToString();
            }
        }

        public string Statusbar
        {
            get
            {
                return toolStripStatusLabel1.Text.ToString();
            }

            set
            {
                toolStripStatusLabel1.Text = value;
            }
        }

        public UInt64 ArtsXover
        {
            get
            {
                return Convert.ToUInt64(tbXoverArts.Text.ToString());
            }
        }

        public UInt64 ArtsArticles
        {
            get
            {
                return Convert.ToUInt64(tbArticleArts.Text.ToString());
            }
        }

        public EArticleCommand ArtCommand
        {
            get
            {
                if (radArtBody.Checked == true)
                    return EArticleCommand.BODY;
                else if (radArtHead.Checked == true)
                    return EArticleCommand.HEAD;
                else // if (radArtArticle.Checked == true)
                    return EArticleCommand.ARTICLE;
            }
        }

        public EArticleMethod ArtMethod
        {
            get
            {
                if (radNumeric.Checked == true)
                    return EArticleMethod.Numeric;
                else // if (radMessageid.Checked == true)
                    return EArticleMethod.Messageid;
            }
        }


        public EArticleAge ArtAge
        {
            get
            {
                if (radAgeNew.Checked == true)
                    return EArticleAge.New;
                else if (radAgeOld.Checked == true)
                    return EArticleAge.Old;
                else // if (radAgeRandom.Checked == true)
                    return EArticleAge.Random;
            }
        }

        public bool JoinGroup
        {
            get
            {
                if (checkJoinGroup.Checked == true)
                    return true;
                else
                    return false;
            }
        }

        //
        // Create some thread safe form updates for the worker thread
        //

        delegate void SetTextCallback(string txt);
        delegate void SetUlongCallback(ulong max);
        delegate void SetVoidCallback();

        public void SetSpeedXover(string spd)
        {
            if (this.speedXover.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SafeSetSpeedXover);
                this.Invoke(d, new object[] { spd });
            }
            else
            {
                SafeSetSpeedXover(spd);
            }
        }
        public void SafeSetSpeedXover(string spd)
        {
            speedXover.Text = spd;
        }

        
        public void SetLatencyArticles(string spd)
        {
            if (this.latencyArticles.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SafeSetLatencyArticles);
                this.Invoke(d, new object[] { spd });
            }
            else
            {
                SafeSetLatencyArticles(spd);
            }
        }
        public void SafeSetLatencyArticles(string spd)
        {
            latencyArticles.Text = spd;
        }


        public void SetSpeedArticles(string spd)
        {
            if (this.speedArticles.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SafeSetSpeedArticles);
                this.Invoke(d, new object[] { spd });
            }
            else
            {
                SafeSetSpeedArticles(spd);
            }
        }
        public void SafeSetSpeedArticles(string spd)
        {
            speedArticles.Text = spd;
        }


        public void SetProgress(ulong max)
        {
            if (this.progressBar1.InvokeRequired)
            {
                SetUlongCallback d = new SetUlongCallback(SafeSetProgress);
                this.Invoke(d, new object[] { max });
            }
            else
            {
                SafeSetProgress(max);
            }
        }
        private void SafeSetProgress(ulong max)
        {
            progressBar1.Minimum = 1;
            progressBar1.Maximum = (int)max;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
        }

        public void DoProgress()
        {
            if (this.progressBar1.InvokeRequired)
            {
                SetVoidCallback d = new SetVoidCallback(SafeDoProgress);
                this.Invoke(d, new object[] {});
            }
            else
            {
                SafeDoProgress();
            }
        }
        private void SafeDoProgress()
        {
            progressBar1.PerformStep();
        }

        //
        //
        //


        private void radNumericMessageid_CheckedChanged(object sender, EventArgs e)
        {
            if ( radMessageid.Checked == false )
                checkJoinGroup.Enabled = false;
            else
                checkJoinGroup.Enabled = true;
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (logform.Visible == false)
            {
                logform.Show();
            }
            else
            {
                logform.Hide();
            }
        }



    }
}
