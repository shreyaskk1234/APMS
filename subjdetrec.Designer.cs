namespace APMS
{
    partial class subjdetrec
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
            this.label1 = new System.Windows.Forms.Label();
            this.textsubjcode = new System.Windows.Forms.TextBox();
            this.textsubjname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scourse = new System.Windows.Forms.ComboBox();
            this.ssubjclass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ssubjtype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textmaxia = new System.Windows.Forms.TextBox();
            this.textmaxiafinal = new System.Windows.Forms.TextBox();
            this.textmmarks = new System.Windows.Forms.TextBox();
            this.textmaxdmarks = new System.Windows.Forms.TextBox();
            this.textmaxvvmarks = new System.Windows.Forms.TextBox();
            this.textminpperc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.bttnsave = new System.Windows.Forms.Button();
            this.bttnreset = new System.Windows.Forms.Button();
            this.ssyllabus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter subject code";
            // 
            // textsubjcode
            // 
            this.textsubjcode.Location = new System.Drawing.Point(159, 19);
            this.textsubjcode.Name = "textsubjcode";
            this.textsubjcode.Size = new System.Drawing.Size(253, 20);
            this.textsubjcode.TabIndex = 1;
            // 
            // textsubjname
            // 
            this.textsubjname.Location = new System.Drawing.Point(159, 67);
            this.textsubjname.Name = "textsubjname";
            this.textsubjname.Size = new System.Drawing.Size(351, 20);
            this.textsubjname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter subject name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Course";
            // 
            // scourse
            // 
            this.scourse.FormattingEnabled = true;
            this.scourse.Location = new System.Drawing.Point(160, 124);
            this.scourse.Name = "scourse";
            this.scourse.Size = new System.Drawing.Size(121, 21);
            this.scourse.TabIndex = 5;
            this.scourse.TextChanged += new System.EventHandler(this.scourse_TextChanged);
            // 
            // ssubjclass
            // 
            this.ssubjclass.FormattingEnabled = true;
            this.ssubjclass.Location = new System.Drawing.Point(435, 124);
            this.ssubjclass.Name = "ssubjclass";
            this.ssubjclass.Size = new System.Drawing.Size(121, 21);
            this.ssubjclass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Sem/year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Specify Syllabus";
            // 
            // ssubjtype
            // 
            this.ssubjtype.BackColor = System.Drawing.SystemColors.Window;
            this.ssubjtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssubjtype.FormattingEnabled = true;
            this.ssubjtype.Items.AddRange(new object[] {
            "General",
            "Project Work",
            "EC/CC",
            "Opt Language",
            "Opt Subject"});
            this.ssubjtype.Location = new System.Drawing.Point(435, 172);
            this.ssubjtype.Name = "ssubjtype";
            this.ssubjtype.Size = new System.Drawing.Size(121, 21);
            this.ssubjtype.TabIndex = 11;
            this.ssubjtype.SelectedIndexChanged += new System.EventHandler(this.ssubjtype_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Specify subject type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Max IA final marks";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Max IA marks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Max main marks";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Max dissertation marks";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Max viva voce marks";
            // 
            // textmaxia
            // 
            this.textmaxia.Location = new System.Drawing.Point(162, 226);
            this.textmaxia.Name = "textmaxia";
            this.textmaxia.Size = new System.Drawing.Size(100, 20);
            this.textmaxia.TabIndex = 18;
            this.textmaxia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.marks_KeyPress);
            // 
            // textmaxiafinal
            // 
            this.textmaxiafinal.Location = new System.Drawing.Point(435, 226);
            this.textmaxiafinal.Name = "textmaxiafinal";
            this.textmaxiafinal.Size = new System.Drawing.Size(100, 20);
            this.textmaxiafinal.TabIndex = 19;
            this.textmaxiafinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.marks_KeyPress);
            // 
            // textmmarks
            // 
            this.textmmarks.Location = new System.Drawing.Point(162, 274);
            this.textmmarks.Name = "textmmarks";
            this.textmmarks.Size = new System.Drawing.Size(100, 20);
            this.textmmarks.TabIndex = 20;
            this.textmmarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.marks_KeyPress);
            // 
            // textmaxdmarks
            // 
            this.textmaxdmarks.Enabled = false;
            this.textmaxdmarks.Location = new System.Drawing.Point(435, 274);
            this.textmaxdmarks.Name = "textmaxdmarks";
            this.textmaxdmarks.Size = new System.Drawing.Size(100, 20);
            this.textmaxdmarks.TabIndex = 21;
            this.textmaxdmarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.marks_KeyPress);
            // 
            // textmaxvvmarks
            // 
            this.textmaxvvmarks.Enabled = false;
            this.textmaxvvmarks.Location = new System.Drawing.Point(162, 324);
            this.textmaxvvmarks.Name = "textmaxvvmarks";
            this.textmaxvvmarks.Size = new System.Drawing.Size(100, 20);
            this.textmaxvvmarks.TabIndex = 22;
            this.textmaxvvmarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.marks_KeyPress);
            // 
            // textminpperc
            // 
            this.textminpperc.Location = new System.Drawing.Point(435, 322);
            this.textminpperc.Name = "textminpperc";
            this.textminpperc.Size = new System.Drawing.Size(100, 20);
            this.textminpperc.TabIndex = 23;
            this.textminpperc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.marks_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Min pass %";
            // 
            // bttnsave
            // 
            this.bttnsave.Location = new System.Drawing.Point(178, 376);
            this.bttnsave.Name = "bttnsave";
            this.bttnsave.Size = new System.Drawing.Size(75, 23);
            this.bttnsave.TabIndex = 25;
            this.bttnsave.Text = "Save";
            this.bttnsave.UseVisualStyleBackColor = true;
            this.bttnsave.Click += new System.EventHandler(this.bttnsave_Click);
            // 
            // bttnreset
            // 
            this.bttnreset.Location = new System.Drawing.Point(379, 376);
            this.bttnreset.Name = "bttnreset";
            this.bttnreset.Size = new System.Drawing.Size(75, 23);
            this.bttnreset.TabIndex = 26;
            this.bttnreset.Text = "Reset";
            this.bttnreset.UseVisualStyleBackColor = true;
            this.bttnreset.Click += new System.EventHandler(this.bttnreset_Click);
            // 
            // ssyllabus
            // 
            this.ssyllabus.FormattingEnabled = true;
            this.ssyllabus.Location = new System.Drawing.Point(160, 172);
            this.ssyllabus.Name = "ssyllabus";
            this.ssyllabus.Size = new System.Drawing.Size(121, 21);
            this.ssyllabus.TabIndex = 27;
            // 
            // subjdetrec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 411);
            this.Controls.Add(this.ssyllabus);
            this.Controls.Add(this.bttnreset);
            this.Controls.Add(this.bttnsave);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textminpperc);
            this.Controls.Add(this.textmaxvvmarks);
            this.Controls.Add(this.textmaxdmarks);
            this.Controls.Add(this.textmmarks);
            this.Controls.Add(this.textmaxiafinal);
            this.Controls.Add(this.textmaxia);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ssubjtype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ssubjclass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.scourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textsubjname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textsubjcode);
            this.Controls.Add(this.label1);
            this.Name = "subjdetrec";
            this.Text = "Subject/Project Work Details Record";
            this.Load += new System.EventHandler(this.subjdetrec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textsubjcode;
        private System.Windows.Forms.TextBox textsubjname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox scourse;
        private System.Windows.Forms.ComboBox ssubjclass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ssubjtype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textmaxia;
        private System.Windows.Forms.TextBox textmaxiafinal;
        private System.Windows.Forms.TextBox textmmarks;
        private System.Windows.Forms.TextBox textmaxdmarks;
        private System.Windows.Forms.TextBox textmaxvvmarks;
        private System.Windows.Forms.TextBox textminpperc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button bttnsave;
        private System.Windows.Forms.Button bttnreset;
        private System.Windows.Forms.ComboBox ssyllabus;
    }
}