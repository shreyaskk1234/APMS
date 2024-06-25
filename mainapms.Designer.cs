namespace APMS
{
    partial class mainapms
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attdrecm = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attdretsessm = new System.Windows.Forms.ToolStripMenuItem();
            this.attdretstsjm = new System.Windows.Forms.ToolStripMenuItem();
            this.attdretperc = new System.Windows.Forms.ToolStripMenuItem();
            this.eventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventrecm = new System.Windows.Forms.ToolStripMenuItem();
            this.eventretm = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marksScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individmkm = new System.Windows.Forms.ToolStripMenuItem();
            this.marksScoreOfAClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classdetmnit = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.retrieveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.curuser = new System.Windows.Forms.Label();
            this.curusertype = new System.Windows.Forms.Label();
            this.welcpict = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcpict)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendanceToolStripMenuItem,
            this.eventToolStripMenuItem,
            this.lecturerToolStripMenuItem,
            this.programToolStripMenuItem,
            this.marksScoreToolStripMenuItem,
            this.studentDetailsToolStripMenuItem,
            this.subjectDetailsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attdrecm,
            this.retrieveToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            // 
            // attdrecm
            // 
            this.attdrecm.Name = "attdrecm";
            this.attdrecm.Size = new System.Drawing.Size(116, 22);
            this.attdrecm.Text = "Record";
            this.attdrecm.Click += new System.EventHandler(this.recordToolStripMenuItem_Click);
            // 
            // retrieveToolStripMenuItem
            // 
            this.retrieveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attdretsessm,
            this.attdretstsjm,
            this.attdretperc});
            this.retrieveToolStripMenuItem.Name = "retrieveToolStripMenuItem";
            this.retrieveToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.retrieveToolStripMenuItem.Text = "Retrieve";
            // 
            // attdretsessm
            // 
            this.attdretsessm.Name = "attdretsessm";
            this.attdretsessm.Size = new System.Drawing.Size(180, 22);
            this.attdretsessm.Text = "Session";
            this.attdretsessm.Click += new System.EventHandler(this.sessionToolStripMenuItem_Click);
            // 
            // attdretstsjm
            // 
            this.attdretstsjm.Name = "attdretstsjm";
            this.attdretstsjm.Size = new System.Drawing.Size(180, 22);
            this.attdretstsjm.Text = "Student and Subject";
            this.attdretstsjm.Click += new System.EventHandler(this.studentAndSubjectToolStripMenuItem_Click);
            // 
            // attdretperc
            // 
            this.attdretperc.Name = "attdretperc";
            this.attdretperc.Size = new System.Drawing.Size(180, 22);
            this.attdretperc.Text = "Percentage %";
            this.attdretperc.Click += new System.EventHandler(this.percentageToolStripMenuItem_Click);
            // 
            // eventToolStripMenuItem
            // 
            this.eventToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventrecm,
            this.eventretm});
            this.eventToolStripMenuItem.Name = "eventToolStripMenuItem";
            this.eventToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.eventToolStripMenuItem.Text = "Event";
            // 
            // eventrecm
            // 
            this.eventrecm.Name = "eventrecm";
            this.eventrecm.Size = new System.Drawing.Size(116, 22);
            this.eventrecm.Text = "Record";
            this.eventrecm.Click += new System.EventHandler(this.recordToolStripMenuItem1_Click);
            // 
            // eventretm
            // 
            this.eventretm.Name = "eventretm";
            this.eventretm.Size = new System.Drawing.Size(116, 22);
            this.eventretm.Text = "Retrieve";
            this.eventretm.Click += new System.EventHandler(this.retrieveToolStripMenuItem1_Click);
            // 
            // lecturerToolStripMenuItem
            // 
            this.lecturerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDetailsToolStripMenuItem});
            this.lecturerToolStripMenuItem.Name = "lecturerToolStripMenuItem";
            this.lecturerToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.lecturerToolStripMenuItem.Text = "Lecturer";
            // 
            // changeDetailsToolStripMenuItem
            // 
            this.changeDetailsToolStripMenuItem.Name = "changeDetailsToolStripMenuItem";
            this.changeDetailsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.changeDetailsToolStripMenuItem.Text = "Change Details";
            this.changeDetailsToolStripMenuItem.Click += new System.EventHandler(this.changeDetailsToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPasswordToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // setPasswordToolStripMenuItem
            // 
            this.setPasswordToolStripMenuItem.Name = "setPasswordToolStripMenuItem";
            this.setPasswordToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.setPasswordToolStripMenuItem.Text = "Set Password";
            this.setPasswordToolStripMenuItem.Click += new System.EventHandler(this.setPasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // marksScoreToolStripMenuItem
            // 
            this.marksScoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.individmkm,
            this.marksScoreOfAClassToolStripMenuItem});
            this.marksScoreToolStripMenuItem.Name = "marksScoreToolStripMenuItem";
            this.marksScoreToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.marksScoreToolStripMenuItem.Text = "Marks Score";
            // 
            // individmkm
            // 
            this.individmkm.Name = "individmkm";
            this.individmkm.Size = new System.Drawing.Size(188, 22);
            this.individmkm.Text = "Individual marks";
            this.individmkm.Click += new System.EventHandler(this.recordToolStripMenuItem4_Click);
            // 
            // marksScoreOfAClassToolStripMenuItem
            // 
            this.marksScoreOfAClassToolStripMenuItem.Name = "marksScoreOfAClassToolStripMenuItem";
            this.marksScoreOfAClassToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.marksScoreOfAClassToolStripMenuItem.Text = "Marks score of a class";
            this.marksScoreOfAClassToolStripMenuItem.Click += new System.EventHandler(this.marksScoreOfAClassToolStripMenuItem_Click);
            // 
            // studentDetailsToolStripMenuItem
            // 
            this.studentDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allDetailsToolStripMenuItem,
            this.classdetmnit});
            this.studentDetailsToolStripMenuItem.Name = "studentDetailsToolStripMenuItem";
            this.studentDetailsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.studentDetailsToolStripMenuItem.Text = "Student Details";
            // 
            // allDetailsToolStripMenuItem
            // 
            this.allDetailsToolStripMenuItem.Name = "allDetailsToolStripMenuItem";
            this.allDetailsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.allDetailsToolStripMenuItem.Text = "All Details";
            this.allDetailsToolStripMenuItem.Click += new System.EventHandler(this.allDetailsToolStripMenuItem_Click);
            // 
            // classdetmnit
            // 
            this.classdetmnit.Name = "classdetmnit";
            this.classdetmnit.Size = new System.Drawing.Size(139, 22);
            this.classdetmnit.Text = "Class Details";
            this.classdetmnit.Click += new System.EventHandler(this.classDetailsToolStripMenuItem_Click);
            // 
            // subjectDetailsToolStripMenuItem
            // 
            this.subjectDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordToolStripMenuItem2,
            this.retrieveToolStripMenuItem2});
            this.subjectDetailsToolStripMenuItem.Name = "subjectDetailsToolStripMenuItem";
            this.subjectDetailsToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.subjectDetailsToolStripMenuItem.Text = "Subject Details";
            // 
            // recordToolStripMenuItem2
            // 
            this.recordToolStripMenuItem2.Name = "recordToolStripMenuItem2";
            this.recordToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.recordToolStripMenuItem2.Text = "Record";
            this.recordToolStripMenuItem2.Click += new System.EventHandler(this.recordToolStripMenuItem2_Click);
            // 
            // retrieveToolStripMenuItem2
            // 
            this.retrieveToolStripMenuItem2.Name = "retrieveToolStripMenuItem2";
            this.retrieveToolStripMenuItem2.Size = new System.Drawing.Size(116, 22);
            this.retrieveToolStripMenuItem2.Text = "Retrieve";
            this.retrieveToolStripMenuItem2.Click += new System.EventHandler(this.retrieveToolStripMenuItem2_Click);
            // 
            // curuser
            // 
            this.curuser.AutoSize = true;
            this.curuser.Location = new System.Drawing.Point(118, 107);
            this.curuser.Name = "curuser";
            this.curuser.Size = new System.Drawing.Size(64, 13);
            this.curuser.TabIndex = 1;
            this.curuser.Text = "Current user";
            // 
            // curusertype
            // 
            this.curusertype.AutoSize = true;
            this.curusertype.Location = new System.Drawing.Point(118, 137);
            this.curusertype.Name = "curusertype";
            this.curusertype.Size = new System.Drawing.Size(56, 13);
            this.curusertype.TabIndex = 2;
            this.curusertype.Text = "User Type";
            // 
            // welcpict
            // 
            this.welcpict.Location = new System.Drawing.Point(120, 192);
            this.welcpict.Name = "welcpict";
            this.welcpict.Size = new System.Drawing.Size(368, 79);
            this.welcpict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcpict.TabIndex = 3;
            this.welcpict.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 10000;
            this.timer.Tick += new System.EventHandler(this.sttimer_Tick);
            // 
            // mainapms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(645, 315);
            this.Controls.Add(this.welcpict);
            this.Controls.Add(this.curusertype);
            this.Controls.Add(this.curuser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainapms";
            this.Text = "Academic Program Management System";
            this.Load += new System.EventHandler(this.mainapms_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.welcpict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attdrecm;
        private System.Windows.Forms.ToolStripMenuItem retrieveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attdretsessm;
        private System.Windows.Forms.ToolStripMenuItem attdretstsjm;
        private System.Windows.Forms.ToolStripMenuItem attdretperc;
        private System.Windows.Forms.ToolStripMenuItem eventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventrecm;
        private System.Windows.Forms.ToolStripMenuItem eventretm;
        private System.Windows.Forms.ToolStripMenuItem lecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marksScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem retrieveToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem individmkm;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classdetmnit;
        private System.Windows.Forms.Label curuser;
        private System.Windows.Forms.Label curusertype;
        private System.Windows.Forms.PictureBox welcpict;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem marksScoreOfAClassToolStripMenuItem;
    }
}