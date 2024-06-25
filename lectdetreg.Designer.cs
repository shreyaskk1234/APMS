namespace APMS
{
    partial class lectdetreg
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
            this.label2 = new System.Windows.Forms.Label();
            this.ssubj = new System.Windows.Forms.ComboBox();
            this.sclass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.scourse = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ssyllabus = new System.Windows.Forms.ComboBox();
            this.listlectsubj = new System.Windows.Forms.ListBox();
            this.slectid = new System.Windows.Forms.ComboBox();
            this.bttnreglect = new System.Windows.Forms.Button();
            this.bttndellect = new System.Windows.Forms.Button();
            this.bttnaddsubj = new System.Windows.Forms.Button();
            this.bttnremsubj = new System.Windows.Forms.Button();
            this.bttnclearsubj = new System.Windows.Forms.Button();
            this.textlname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturer id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lecturer name";
            // 
            // ssubj
            // 
            this.ssubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssubj.FormattingEnabled = true;
            this.ssubj.Location = new System.Drawing.Point(415, 142);
            this.ssubj.Name = "ssubj";
            this.ssubj.Size = new System.Drawing.Size(254, 21);
            this.ssubj.TabIndex = 20;
            // 
            // sclass
            // 
            this.sclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sclass.FormattingEnabled = true;
            this.sclass.Location = new System.Drawing.Point(415, 96);
            this.sclass.Name = "sclass";
            this.sclass.Size = new System.Drawing.Size(121, 21);
            this.sclass.TabIndex = 19;
            this.sclass.SelectedIndexChanged += new System.EventHandler(this.sclass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Select subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Select course";
            // 
            // scourse
            // 
            this.scourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scourse.FormattingEnabled = true;
            this.scourse.Location = new System.Drawing.Point(146, 96);
            this.scourse.Name = "scourse";
            this.scourse.Size = new System.Drawing.Size(121, 21);
            this.scourse.TabIndex = 15;
            this.scourse.SelectedIndexChanged += new System.EventHandler(this.scourse_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Select syllabus";
            // 
            // ssyllabus
            // 
            this.ssyllabus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssyllabus.FormattingEnabled = true;
            this.ssyllabus.Location = new System.Drawing.Point(146, 142);
            this.ssyllabus.Name = "ssyllabus";
            this.ssyllabus.Size = new System.Drawing.Size(121, 21);
            this.ssyllabus.TabIndex = 34;
            this.ssyllabus.SelectedIndexChanged += new System.EventHandler(this.ssyllabus_SelectedIndexChanged);
            // 
            // listlectsubj
            // 
            this.listlectsubj.FormattingEnabled = true;
            this.listlectsubj.Location = new System.Drawing.Point(49, 197);
            this.listlectsubj.Name = "listlectsubj";
            this.listlectsubj.Size = new System.Drawing.Size(258, 121);
            this.listlectsubj.TabIndex = 36;
            // 
            // slectid
            // 
            this.slectid.FormattingEnabled = true;
            this.slectid.Location = new System.Drawing.Point(146, 6);
            this.slectid.MaxLength = 20;
            this.slectid.Name = "slectid";
            this.slectid.Size = new System.Drawing.Size(121, 21);
            this.slectid.TabIndex = 37;
            this.slectid.SelectedIndexChanged += new System.EventHandler(this.slectid_SelectedIndexChanged);
            // 
            // bttnreglect
            // 
            this.bttnreglect.Location = new System.Drawing.Point(402, 12);
            this.bttnreglect.Name = "bttnreglect";
            this.bttnreglect.Size = new System.Drawing.Size(116, 31);
            this.bttnreglect.TabIndex = 39;
            this.bttnreglect.Text = "Register/Edit";
            this.bttnreglect.UseVisualStyleBackColor = true;
            this.bttnreglect.Click += new System.EventHandler(this.bttnreglect_Click);
            // 
            // bttndellect
            // 
            this.bttndellect.Location = new System.Drawing.Point(567, 12);
            this.bttndellect.Name = "bttndellect";
            this.bttndellect.Size = new System.Drawing.Size(105, 31);
            this.bttndellect.TabIndex = 40;
            this.bttndellect.Text = "Delete";
            this.bttndellect.UseVisualStyleBackColor = true;
            this.bttndellect.Click += new System.EventHandler(this.bttndellect_Click);
            // 
            // bttnaddsubj
            // 
            this.bttnaddsubj.Location = new System.Drawing.Point(335, 219);
            this.bttnaddsubj.Name = "bttnaddsubj";
            this.bttnaddsubj.Size = new System.Drawing.Size(82, 31);
            this.bttnaddsubj.TabIndex = 41;
            this.bttnaddsubj.Text = "Add";
            this.bttnaddsubj.UseVisualStyleBackColor = true;
            this.bttnaddsubj.Click += new System.EventHandler(this.bttnaddsubj_Click);
            // 
            // bttnremsubj
            // 
            this.bttnremsubj.Location = new System.Drawing.Point(436, 219);
            this.bttnremsubj.Name = "bttnremsubj";
            this.bttnremsubj.Size = new System.Drawing.Size(82, 31);
            this.bttnremsubj.TabIndex = 42;
            this.bttnremsubj.Text = "Remove";
            this.bttnremsubj.UseVisualStyleBackColor = true;
            this.bttnremsubj.Click += new System.EventHandler(this.bttnremsubj_Click);
            // 
            // bttnclearsubj
            // 
            this.bttnclearsubj.Location = new System.Drawing.Point(539, 219);
            this.bttnclearsubj.Name = "bttnclearsubj";
            this.bttnclearsubj.Size = new System.Drawing.Size(82, 31);
            this.bttnclearsubj.TabIndex = 43;
            this.bttnclearsubj.Text = "Clear";
            this.bttnclearsubj.UseVisualStyleBackColor = true;
            this.bttnclearsubj.Click += new System.EventHandler(this.bttnclearsubj_Click);
            // 
            // textlname
            // 
            this.textlname.Location = new System.Drawing.Point(146, 45);
            this.textlname.Name = "textlname";
            this.textlname.Size = new System.Drawing.Size(204, 20);
            this.textlname.TabIndex = 44;
            // 
            // lectdetreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 333);
            this.Controls.Add(this.textlname);
            this.Controls.Add(this.bttnclearsubj);
            this.Controls.Add(this.bttnremsubj);
            this.Controls.Add(this.bttnaddsubj);
            this.Controls.Add(this.bttndellect);
            this.Controls.Add(this.bttnreglect);
            this.Controls.Add(this.slectid);
            this.Controls.Add(this.listlectsubj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ssyllabus);
            this.Controls.Add(this.ssubj);
            this.Controls.Add(this.sclass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.scourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "lectdetreg";
            this.Text = "Register/Retrieve lecturer details";
            this.Load += new System.EventHandler(this.lectaddreg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ssubj;
        private System.Windows.Forms.ComboBox sclass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox scourse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ssyllabus;
        private System.Windows.Forms.ListBox listlectsubj;
        private System.Windows.Forms.ComboBox slectid;
        private System.Windows.Forms.Button bttnreglect;
        private System.Windows.Forms.Button bttndellect;
        private System.Windows.Forms.Button bttnaddsubj;
        private System.Windows.Forms.Button bttnremsubj;
        private System.Windows.Forms.Button bttnclearsubj;
        private System.Windows.Forms.TextBox textlname;
    }
}