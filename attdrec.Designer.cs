namespace APMS
{
    partial class attdrec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attdrec));
            this.label1 = new System.Windows.Forms.Label();
            this.textrollno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.datesess = new System.Windows.Forms.DateTimePicker();
            this.optmarkpres = new System.Windows.Forms.CheckBox();
            this.optmarkopps = new System.Windows.Forms.CheckBox();
            this.bttnrec = new System.Windows.Forms.Button();
            this.bttnres = new System.Windows.Forms.Button();
            this.ssyllabus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ssubj = new System.Windows.Forms.ComboBox();
            this.sclass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scourse = new System.Windows.Forms.ComboBox();
            this.sbatch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.opteditm = new System.Windows.Forms.CheckBox();
            this.textssno = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timesess = new System.Windows.Forms.DateTimePicker();
            this.optconstime = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter roll nos";
            // 
            // textrollno
            // 
            this.textrollno.Location = new System.Drawing.Point(117, 271);
            this.textrollno.Multiline = true;
            this.textrollno.Name = "textrollno";
            this.textrollno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textrollno.Size = new System.Drawing.Size(260, 83);
            this.textrollno.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date of session";
            // 
            // datesess
            // 
            this.datesess.Location = new System.Drawing.Point(117, 389);
            this.datesess.Name = "datesess";
            this.datesess.Size = new System.Drawing.Size(200, 20);
            this.datesess.TabIndex = 11;
            // 
            // optmarkpres
            // 
            this.optmarkpres.AutoSize = true;
            this.optmarkpres.Location = new System.Drawing.Point(23, 490);
            this.optmarkpres.Name = "optmarkpres";
            this.optmarkpres.Size = new System.Drawing.Size(89, 17);
            this.optmarkpres.TabIndex = 14;
            this.optmarkpres.Text = "Mark Present";
            this.optmarkpres.UseVisualStyleBackColor = true;
            // 
            // optmarkopps
            // 
            this.optmarkopps.AutoSize = true;
            this.optmarkopps.Checked = true;
            this.optmarkopps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optmarkopps.Location = new System.Drawing.Point(23, 524);
            this.optmarkopps.Name = "optmarkopps";
            this.optmarkopps.Size = new System.Drawing.Size(163, 17);
            this.optmarkopps.TabIndex = 15;
            this.optmarkopps.Text = "Mark other students opposite";
            this.optmarkopps.UseVisualStyleBackColor = true;
            // 
            // bttnrec
            // 
            this.bttnrec.Location = new System.Drawing.Point(63, 573);
            this.bttnrec.Name = "bttnrec";
            this.bttnrec.Size = new System.Drawing.Size(75, 23);
            this.bttnrec.TabIndex = 16;
            this.bttnrec.Text = "Record";
            this.bttnrec.UseVisualStyleBackColor = true;
            this.bttnrec.Click += new System.EventHandler(this.bttnrec_Click);
            // 
            // bttnres
            // 
            this.bttnres.Location = new System.Drawing.Point(166, 573);
            this.bttnres.Name = "bttnres";
            this.bttnres.Size = new System.Drawing.Size(75, 23);
            this.bttnres.TabIndex = 17;
            this.bttnres.Text = "Reset";
            this.bttnres.UseVisualStyleBackColor = true;
            this.bttnres.Click += new System.EventHandler(this.bttnres_Click);
            // 
            // ssyllabus
            // 
            this.ssyllabus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssyllabus.FormattingEnabled = true;
            this.ssyllabus.Location = new System.Drawing.Point(117, 60);
            this.ssyllabus.Name = "ssyllabus";
            this.ssyllabus.Size = new System.Drawing.Size(121, 21);
            this.ssyllabus.TabIndex = 28;
            this.ssyllabus.SelectedIndexChanged += new System.EventHandler(this.ssyllabus_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Select syllabus";
            // 
            // ssubj
            // 
            this.ssubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssubj.FormattingEnabled = true;
            this.ssubj.Location = new System.Drawing.Point(117, 142);
            this.ssubj.Name = "ssubj";
            this.ssubj.Size = new System.Drawing.Size(292, 21);
            this.ssubj.TabIndex = 26;
            this.ssubj.SelectedIndexChanged += new System.EventHandler(this.ssubj_SelectedIndexChanged);
            // 
            // sclass
            // 
            this.sclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sclass.FormattingEnabled = true;
            this.sclass.Location = new System.Drawing.Point(117, 102);
            this.sclass.Name = "sclass";
            this.sclass.Size = new System.Drawing.Size(56, 21);
            this.sclass.TabIndex = 25;
            this.sclass.SelectedIndexChanged += new System.EventHandler(this.sclass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Select subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Select class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Select course";
            // 
            // scourse
            // 
            this.scourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scourse.FormattingEnabled = true;
            this.scourse.Location = new System.Drawing.Point(117, 17);
            this.scourse.Name = "scourse";
            this.scourse.Size = new System.Drawing.Size(121, 21);
            this.scourse.TabIndex = 21;
            this.scourse.SelectedIndexChanged += new System.EventHandler(this.scourse_SelectedIndexChanged);
            // 
            // sbatch
            // 
            this.sbatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sbatch.FormattingEnabled = true;
            this.sbatch.Location = new System.Drawing.Point(117, 184);
            this.sbatch.Name = "sbatch";
            this.sbatch.Size = new System.Drawing.Size(121, 21);
            this.sbatch.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Select batch";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Session no";
            // 
            // opteditm
            // 
            this.opteditm.AutoSize = true;
            this.opteditm.Location = new System.Drawing.Point(184, 490);
            this.opteditm.Name = "opteditm";
            this.opteditm.Size = new System.Drawing.Size(74, 17);
            this.opteditm.TabIndex = 37;
            this.opteditm.Text = "Edit Mode";
            this.opteditm.UseVisualStyleBackColor = true;
            // 
            // textssno
            // 
            this.textssno.Location = new System.Drawing.Point(117, 228);
            this.textssno.Name = "textssno";
            this.textssno.Size = new System.Drawing.Size(83, 20);
            this.textssno.TabIndex = 38;
            this.textssno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textssno_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 424);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 453);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Optional time";
            // 
            // timesess
            // 
            this.timesess.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timesess.Location = new System.Drawing.Point(117, 453);
            this.timesess.Name = "timesess";
            this.timesess.Size = new System.Drawing.Size(121, 20);
            this.timesess.TabIndex = 41;
            this.timesess.Value = new System.DateTime(2015, 3, 1, 19, 11, 0, 0);
            // 
            // optconstime
            // 
            this.optconstime.AutoSize = true;
            this.optconstime.Location = new System.Drawing.Point(45, 424);
            this.optconstime.Name = "optconstime";
            this.optconstime.Size = new System.Drawing.Size(93, 17);
            this.optconstime.TabIndex = 40;
            this.optconstime.Text = "Consider Time";
            this.optconstime.UseVisualStyleBackColor = true;
            // 
            // attdrec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 616);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timesess);
            this.Controls.Add(this.optconstime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textssno);
            this.Controls.Add(this.opteditm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sbatch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ssyllabus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ssubj);
            this.Controls.Add(this.sclass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bttnres);
            this.Controls.Add(this.bttnrec);
            this.Controls.Add(this.optmarkopps);
            this.Controls.Add(this.optmarkpres);
            this.Controls.Add(this.datesess);
            this.Controls.Add(this.textrollno);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "attdrec";
            this.Text = "Record Attendance";
            this.Load += new System.EventHandler(this.attdrec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textrollno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datesess;
        private System.Windows.Forms.CheckBox optmarkpres;
        private System.Windows.Forms.CheckBox optmarkopps;
        private System.Windows.Forms.Button bttnrec;
        private System.Windows.Forms.Button bttnres;
        private System.Windows.Forms.ComboBox ssyllabus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ssubj;
        private System.Windows.Forms.ComboBox sclass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox scourse;
        private System.Windows.Forms.ComboBox sbatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox opteditm;
        private System.Windows.Forms.TextBox textssno;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timesess;
        private System.Windows.Forms.CheckBox optconstime;
    }
}