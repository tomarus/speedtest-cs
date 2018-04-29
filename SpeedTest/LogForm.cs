using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SpeedTest
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(this.LogForm_Closed);
        }

        //
        //
        //

        private StatusEventHandler logfile;

        public void SetLogHandler(NNTPClient nc)
        {
            logfile = new StatusEventHandler(ListChanged);
            nc.StatusMessage += logfile; // new StatusEventHandler(LogForm.ListChanged);
        }

        public void ListChanged(object sender, StatusEventArgs e)
        {
            AppendText(e.Status + "\n");
        }

        //
        //
        //

        private void LogForm_Closed(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        //
        //
        //

        delegate void SetTextCallback(string txt);

        public void AppendText(string msg)
        {
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SafeAppendText);
                this.Invoke(d, new object[] { msg });
            }
            else
            {
                SafeAppendText(msg);
            }
        }
        public void SafeAppendText(string msg)
        {
            //textBox1.Lines[textBox1.Lines.Length] = msg;
            textBox1.AppendText(msg);
        }
    }
}
