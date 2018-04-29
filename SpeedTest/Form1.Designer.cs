namespace SpeedTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bStart = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNewsgroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radMessageid = new System.Windows.Forms.RadioButton();
            this.radNumeric = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radArtHead = new System.Windows.Forms.RadioButton();
            this.radArtBody = new System.Windows.Forms.RadioButton();
            this.radArtArticle = new System.Windows.Forms.RadioButton();
            this.checkJoinGroup = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.speedArticles = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.latencyArticles = new System.Windows.Forms.Label();
            this.speedXover = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radAgeRandom = new System.Windows.Forms.RadioButton();
            this.radAgeNew = new System.Windows.Forms.RadioButton();
            this.radAgeOld = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbArticleArts = new SpeedTest.NumbersOnlyTextBox();
            this.tbXoverArts = new SpeedTest.NumbersOnlyTextBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(119, 493);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start Tests";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(29, 493);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 23);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbNewsgroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbHostname);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 130);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Setup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Tag = "";
            this.label5.Text = "Newsgroup:";
            // 
            // tbNewsgroup
            // 
            this.tbNewsgroup.Location = new System.Drawing.Point(121, 99);
            this.tbNewsgroup.Name = "tbNewsgroup";
            this.tbNewsgroup.Size = new System.Drawing.Size(155, 20);
            this.tbNewsgroup.TabIndex = 6;
            this.tbNewsgroup.Tag = "";
            this.tbNewsgroup.Text = "alt.binaries.test";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(121, 73);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(155, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(121, 47);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(155, 20);
            this.tbUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server Hostname:";
            // 
            // tbHostname
            // 
            this.tbHostname.Location = new System.Drawing.Point(121, 21);
            this.tbHostname.Name = "tbHostname";
            this.tbHostname.Size = new System.Drawing.Size(155, 20);
            this.tbHostname.TabIndex = 0;
            this.tbHostname.Text = "news.news-service.com";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbArticleArts);
            this.groupBox2.Controls.Add(this.tbXoverArts);
            this.groupBox2.Location = new System.Drawing.Point(12, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 76);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 18;
            this.label7.Tag = "";
            this.label7.Text = "Articles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Tag = "";
            this.label6.Text = "Overview";
            // 
            // radMessageid
            // 
            this.radMessageid.AutoSize = true;
            this.radMessageid.Checked = true;
            this.radMessageid.Location = new System.Drawing.Point(24, 35);
            this.radMessageid.Name = "radMessageid";
            this.radMessageid.Size = new System.Drawing.Size(87, 17);
            this.radMessageid.TabIndex = 21;
            this.radMessageid.TabStop = true;
            this.radMessageid.Text = "Message-IDs";
            this.radMessageid.UseVisualStyleBackColor = true;
            this.radMessageid.CheckedChanged += new System.EventHandler(this.radNumericMessageid_CheckedChanged);
            // 
            // radNumeric
            // 
            this.radNumeric.AutoSize = true;
            this.radNumeric.Location = new System.Drawing.Point(24, 17);
            this.radNumeric.Name = "radNumeric";
            this.radNumeric.Size = new System.Drawing.Size(64, 17);
            this.radNumeric.TabIndex = 20;
            this.radNumeric.Text = "Numeric";
            this.radNumeric.UseVisualStyleBackColor = true;
            this.radNumeric.CheckedChanged += new System.EventHandler(this.radNumericMessageid_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 464);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(295, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Test Progress";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 523);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(319, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel1.Text = "Initializing";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radArtHead);
            this.groupBox3.Controls.Add(this.radArtBody);
            this.groupBox3.Controls.Add(this.radArtArticle);
            this.groupBox3.Location = new System.Drawing.Point(162, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 76);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Command";
            // 
            // radArtHead
            // 
            this.radArtHead.AutoSize = true;
            this.radArtHead.Location = new System.Drawing.Point(25, 48);
            this.radArtHead.Name = "radArtHead";
            this.radArtHead.Size = new System.Drawing.Size(55, 17);
            this.radArtHead.TabIndex = 16;
            this.radArtHead.Text = "HEAD";
            this.radArtHead.UseVisualStyleBackColor = true;
            // 
            // radArtBody
            // 
            this.radArtBody.AutoSize = true;
            this.radArtBody.Location = new System.Drawing.Point(25, 30);
            this.radArtBody.Name = "radArtBody";
            this.radArtBody.Size = new System.Drawing.Size(55, 17);
            this.radArtBody.TabIndex = 14;
            this.radArtBody.Text = "BODY";
            this.radArtBody.UseVisualStyleBackColor = true;
            // 
            // radArtArticle
            // 
            this.radArtArticle.AutoSize = true;
            this.radArtArticle.Checked = true;
            this.radArtArticle.Location = new System.Drawing.Point(25, 13);
            this.radArtArticle.Name = "radArtArticle";
            this.radArtArticle.Size = new System.Drawing.Size(70, 17);
            this.radArtArticle.TabIndex = 13;
            this.radArtArticle.TabStop = true;
            this.radArtArticle.Text = "ARTICLE";
            this.radArtArticle.UseVisualStyleBackColor = true;
            // 
            // checkJoinGroup
            // 
            this.checkJoinGroup.AutoSize = true;
            this.checkJoinGroup.Location = new System.Drawing.Point(43, 54);
            this.checkJoinGroup.Name = "checkJoinGroup";
            this.checkJoinGroup.Size = new System.Drawing.Size(87, 17);
            this.checkJoinGroup.TabIndex = 22;
            this.checkJoinGroup.Text = "Join GROUP";
            this.checkJoinGroup.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.speedArticles);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.latencyArticles);
            this.groupBox4.Controls.Add(this.speedXover);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(13, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 73);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Test Results";
            // 
            // speedArticles
            // 
            this.speedArticles.AutoSize = true;
            this.speedArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedArticles.Location = new System.Drawing.Point(148, 50);
            this.speedArticles.Name = "speedArticles";
            this.speedArticles.Size = new System.Drawing.Size(45, 13);
            this.speedArticles.TabIndex = 5;
            this.speedArticles.Text = "0 kbps";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(71, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Article Speed:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // latencyArticles
            // 
            this.latencyArticles.AutoSize = true;
            this.latencyArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latencyArticles.Location = new System.Drawing.Point(148, 33);
            this.latencyArticles.Name = "latencyArticles";
            this.latencyArticles.Size = new System.Drawing.Size(33, 13);
            this.latencyArticles.TabIndex = 3;
            this.latencyArticles.Text = "0 ms";
            // 
            // speedXover
            // 
            this.speedXover.AutoSize = true;
            this.speedXover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedXover.Location = new System.Drawing.Point(148, 16);
            this.speedXover.Name = "speedXover";
            this.speedXover.Size = new System.Drawing.Size(45, 13);
            this.speedXover.TabIndex = 2;
            this.speedXover.Text = "0 kbps";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Article Latency:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Overview Speed:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radMessageid);
            this.groupBox5.Controls.Add(this.checkJoinGroup);
            this.groupBox5.Controls.Add(this.radNumeric);
            this.groupBox5.Location = new System.Drawing.Point(163, 287);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(144, 78);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mode";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radAgeRandom);
            this.groupBox6.Controls.Add(this.radAgeNew);
            this.groupBox6.Controls.Add(this.radAgeOld);
            this.groupBox6.Location = new System.Drawing.Point(12, 289);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(144, 76);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Article Age";
            // 
            // radAgeRandom
            // 
            this.radAgeRandom.AutoSize = true;
            this.radAgeRandom.Location = new System.Drawing.Point(22, 51);
            this.radAgeRandom.Name = "radAgeRandom";
            this.radAgeRandom.Size = new System.Drawing.Size(65, 17);
            this.radAgeRandom.TabIndex = 16;
            this.radAgeRandom.Text = "Random";
            this.radAgeRandom.UseVisualStyleBackColor = true;
            // 
            // radAgeNew
            // 
            this.radAgeNew.AutoSize = true;
            this.radAgeNew.Checked = true;
            this.radAgeNew.Location = new System.Drawing.Point(22, 33);
            this.radAgeNew.Name = "radAgeNew";
            this.radAgeNew.Size = new System.Drawing.Size(84, 17);
            this.radAgeNew.TabIndex = 14;
            this.radAgeNew.TabStop = true;
            this.radAgeNew.Text = "New Articles";
            this.radAgeNew.UseVisualStyleBackColor = true;
            // 
            // radAgeOld
            // 
            this.radAgeOld.AutoSize = true;
            this.radAgeOld.Location = new System.Drawing.Point(22, 16);
            this.radAgeOld.Name = "radAgeOld";
            this.radAgeOld.Size = new System.Drawing.Size(78, 17);
            this.radAgeOld.TabIndex = 13;
            this.radAgeOld.Text = "Old Articles";
            this.radAgeOld.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpeedTest.Properties.Resources.Speedtest_Logo1;
            this.pictureBox1.InitialImage = global::SpeedTest.Properties.Resources.Speedtest_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 65);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tbArticleArts
            // 
            this.tbArticleArts.Location = new System.Drawing.Point(73, 45);
            this.tbArticleArts.Name = "tbArticleArts";
            this.tbArticleArts.Size = new System.Drawing.Size(47, 20);
            this.tbArticleArts.TabIndex = 19;
            this.tbArticleArts.Text = "500";
            // 
            // tbXoverArts
            // 
            this.tbXoverArts.Location = new System.Drawing.Point(72, 19);
            this.tbXoverArts.Name = "tbXoverArts";
            this.tbXoverArts.Size = new System.Drawing.Size(48, 20);
            this.tbXoverArts.TabIndex = 10;
            this.tbXoverArts.Text = "100000";
            // 
            // buttonLog
            // 
            this.buttonLog.Location = new System.Drawing.Point(211, 493);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(75, 23);
            this.buttonLog.TabIndex = 24;
            this.buttonLog.Text = "Log";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 545);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Usenet Speedtest";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHostname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNewsgroup;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label6;
        private NumbersOnlyTextBox tbXoverArts;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private NumbersOnlyTextBox tbArticleArts;
        private System.Windows.Forms.RadioButton radArtHead;
        private System.Windows.Forms.RadioButton radArtBody;
        private System.Windows.Forms.RadioButton radArtArticle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radMessageid;
        private System.Windows.Forms.RadioButton radNumeric;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label latencyArticles;
        private System.Windows.Forms.Label speedXover;
        private System.Windows.Forms.Label speedArticles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkJoinGroup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radAgeRandom;
        private System.Windows.Forms.RadioButton radAgeNew;
        private System.Windows.Forms.RadioButton radAgeOld;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonLog;
    }
}