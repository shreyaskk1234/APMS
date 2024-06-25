namespace APMS
{
    partial class marksscor
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
            this.sclass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scourse = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.smarkstype = new System.Windows.Forms.ComboBox();
            this.optbgscor = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sattno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ssyllabus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textrno = new System.Windows.Forms.TextBox();
            this.textsmarks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bttnsave = new System.Windows.Forms.Button();
            this.labelstname = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lsmaxmk = new System.Windows.Forms.Label();
            this.ssubj = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sclass
            // 
            this.sclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sclass.FormattingEnabled = true;
            this.sclass.Location = new System.Drawing.Point(142, 85);
            this.sclass.Name = "sclass";
            this.sclass.Size = new System.Drawing.Size(55, 21);
            this.sclass.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Class(sem/year)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Course";
            // 
            // scourse
            // 
            this.scourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scourse.FormattingEnabled = true;
            this.scourse.Location = new System.Drawing.Point(142, 9);
            this.scourse.Name = "scourse";
            this.scourse.Size = new System.Drawing.Size(121, 21);
            this.scourse.TabIndex = 9;
            this.scourse.SelectedIndexChanged += new System.EventHandler(this.scourse_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Marks type";
            // 
            // smarkstype
            // 
            this.smarkstype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.smarkstype.FormattingEnabled = true;
            this.smarkstype.Items.AddRange(new object[] {
            "First IA",
            "Second IA",
            "IA Aggregate",
            "Main marks"});
            this.smarkstype.Location = new System.Drawing.Point(142, 247);
            this.smarkstype.Name = "smarkstype";
            this.smarkstype.Size = new System.Drawing.Size(100, 21);
            this.smarkstype.TabIndex = 16;
            this.smarkstype.SelectedIndexChanged += new System.EventHandler(this.smarkstype_SelectedIndexChanged);
            // 
            // optbgscor
            // 
            this.optbgscor.AutoSize = true;
            this.optbgscor.Enabled = false;
            this.optbgscor.Location = new System.Drawing.Point(32, 285);
            this.optbgscor.Name = "optbgscor";
            this.optbgscor.Size = new System.Drawing.Size(94, 17);
            this.optbgscor.TabIndex = 17;
            this.optbgscor.Text = "Backlog score";
            this.optbgscor.UseVisualStyleBackColor = true;
            this.optbgscor.CheckedChanged += new System.EventHandler(this.optbgscor_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Attempt no";
            // 
            // sattno
            // 
            this.sattno.Enabled = false;
            this.sattno.FormattingEnabled = true;
            this.sattno.Location = new System.Drawing.Point(252, 283);
            this.sattno.Name = "sattno";
            this.sattno.Size = new System.Drawing.Size(46, 21);
            this.sattno.TabIndex = 19;
            this.sattno.SelectedIndexChanged += new System.EventHandler(this.satno_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Roll No";
            // 
            // ssyllabus
            // 
            this.ssyllabus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssyllabus.FormattingEnabled = true;
            this.ssyllabus.Location = new System.Drawing.Point(142, 47);
            this.ssyllabus.Name = "ssyllabus";
            this.ssyllabus.Size = new System.Drawing.Size(121, 21);
            this.ssyllabus.TabIndex = 30;
            this.ssyllabus.SelectedIndexChanged += new System.EventHandler(this.ssyllabus_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Syllabus";
            // 
            // textrno
            // 
            this.textrno.Location = new System.Drawing.Point(142, 124);
            this.textrno.Name = "textrno";
            this.textrno.Size = new System.Drawing.Size(100, 20);
            this.textrno.TabIndex = 31;
            this.textrno.TextChanged += new System.EventHandler(this.textrno_TextChanged);
            this.textrno.Leave += new System.EventHandler(this.textrno_Leave);
            // 
            // textsmarks
            // 
            this.textsmarks.Location = new System.Drawing.Point(142, 375);
            this.textsmarks.MaxLength = 5;
            this.textsmarks.Name = "textsmarks";
            this.textsmarks.Size = new System.Drawing.Size(50, 20);
            this.textsmarks.TabIndex = 32;
            this.textsmarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textsmarks_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Marks";
            // 
            // bttnsave
            // 
            this.bttnsave.Location = new System.Drawing.Point(373, 41);
            this.bttnsave.Name = "bttnsave";
            this.bttnsave.Size = new System.Drawing.Size(75, 27);
            this.bttnsave.TabIndex = 34;
            this.bttnsave.Text = "Save";
            this.bttnsave.UseVisualStyleBackColor = true;
            this.bttnsave.Click += new System.EventHandler(this.bttnsave_Click);
            // 
            // labelstname
            // 
            this.labelstname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelstname.Location = new System.Drawing.Point(142, 165);
            this.labelstname.Name = "labelstname";
            this.labelstname.Size = new System.Drawing.Size(268, 20);
            this.labelstname.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Max marks";
            // 
            // lsmaxmk
            // 
            this.lsmaxmk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lsmaxmk.Location = new System.Drawing.Point(142, 328);
            this.lsmaxmk.Name = "lsmaxmk";
            this.lsmaxmk.Size = new System.Drawing.Size(100, 22);
            this.lsmaxmk.TabIndex = 41;
            // 
            // ssubj
            // 
            this.ssubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssubj.FormattingEnabled = true;
            this.ssubj.Location = new System.Drawing.Point(142, 206);
            this.ssubj.Name = "ssubj";
            this.ssubj.Size = new System.Drawing.Size(238, 21);
            this.ssubj.TabIndex = 43;
            this.ssubj.SelectedIndexChanged += new System.EventHandler(this.ssubj_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Subject";
            // 
            // marksscor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 412);
            this.Controls.Add(this.ssubj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsmaxmk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelstname);
            this.Controls.Add(this.bttnsave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textsmarks);
            this.Controls.Add(this.textrno);
            this.Controls.Add(this.ssyllabus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sattno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.optbgscor);
            this.Controls.Add(this.smarkstype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sclass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scourse);
            this.Name = "marksscor";
            this.Text = "Marks Score ";
            this.Load += new System.EventHandler(this.marksscrec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sclass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox scourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox smarkstype;
        private System.Windows.Forms.CheckBox optbgscor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sattno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ssyllabus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textrno;
        private System.Windows.Forms.TextBox textsmarks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttnsave;
        private System.Windows.Forms.Label labelstname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lsmaxmk;
        private System.Windows.Forms.ComboBox ssubj;
        private System.Windows.Forms.Label label4;
    }
}