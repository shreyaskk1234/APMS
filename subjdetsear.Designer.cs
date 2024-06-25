namespace APMS
{
    partial class subjdetsear
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
            this.label3 = new System.Windows.Forms.Label();
            this.sclass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scourse = new System.Windows.Forms.ComboBox();
            this.textsubjcr = new System.Windows.Forms.TextBox();
            this.ssyllabus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ssubjtype = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttndispsubjdet = new System.Windows.Forms.Button();
            this.bttneditsubjdet = new System.Windows.Forms.Button();
            this.bttndelsubjdet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search criteria of subject name";
            // 
            // sclass
            // 
            this.sclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sclass.FormattingEnabled = true;
            this.sclass.Location = new System.Drawing.Point(121, 59);
            this.sclass.Name = "sclass";
            this.sclass.Size = new System.Drawing.Size(121, 21);
            this.sclass.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select course";
            // 
            // scourse
            // 
            this.scourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scourse.FormattingEnabled = true;
            this.scourse.Location = new System.Drawing.Point(121, 15);
            this.scourse.Name = "scourse";
            this.scourse.Size = new System.Drawing.Size(121, 21);
            this.scourse.TabIndex = 8;
            this.scourse.SelectedIndexChanged += new System.EventHandler(this.scourse_SelectedIndexChanged);
            // 
            // textsubjcr
            // 
            this.textsubjcr.Location = new System.Drawing.Point(591, 38);
            this.textsubjcr.Name = "textsubjcr";
            this.textsubjcr.Size = new System.Drawing.Size(218, 20);
            this.textsubjcr.TabIndex = 12;
            // 
            // ssyllabus
            // 
            this.ssyllabus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssyllabus.FormattingEnabled = true;
            this.ssyllabus.Location = new System.Drawing.Point(428, 18);
            this.ssyllabus.Name = "ssyllabus";
            this.ssyllabus.Size = new System.Drawing.Size(121, 21);
            this.ssyllabus.TabIndex = 14;
            this.ssyllabus.SelectedIndexChanged += new System.EventHandler(this.ssyllabus_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select syllabus";
            // 
            // ssubjtype
            // 
            this.ssubjtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssubjtype.FormattingEnabled = true;
            this.ssubjtype.Items.AddRange(new object[] {
            "General",
            "Project Work",
            "EC/CC",
            "Opt Language",
            "Opt Subject"});
            this.ssubjtype.Location = new System.Drawing.Point(428, 62);
            this.ssubjtype.Name = "ssubjtype";
            this.ssubjtype.Size = new System.Drawing.Size(121, 21);
            this.ssubjtype.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Specify subject type";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1219, 525);
            this.dataGridView1.TabIndex = 17;
            // 
            // bttndispsubjdet
            // 
            this.bttndispsubjdet.Location = new System.Drawing.Point(873, 18);
            this.bttndispsubjdet.Name = "bttndispsubjdet";
            this.bttndispsubjdet.Size = new System.Drawing.Size(75, 23);
            this.bttndispsubjdet.TabIndex = 18;
            this.bttndispsubjdet.Text = "Display";
            this.bttndispsubjdet.UseVisualStyleBackColor = true;
            this.bttndispsubjdet.Click += new System.EventHandler(this.bttndispsubjdet_Click);
            // 
            // bttneditsubjdet
            // 
            this.bttneditsubjdet.Location = new System.Drawing.Point(984, 18);
            this.bttneditsubjdet.Name = "bttneditsubjdet";
            this.bttneditsubjdet.Size = new System.Drawing.Size(75, 23);
            this.bttneditsubjdet.TabIndex = 19;
            this.bttneditsubjdet.Text = "Edit";
            this.bttneditsubjdet.UseVisualStyleBackColor = true;
            this.bttneditsubjdet.Click += new System.EventHandler(this.bttneditsubjdet_Click);
            // 
            // bttndelsubjdet
            // 
            this.bttndelsubjdet.Location = new System.Drawing.Point(1100, 18);
            this.bttndelsubjdet.Name = "bttndelsubjdet";
            this.bttndelsubjdet.Size = new System.Drawing.Size(75, 23);
            this.bttndelsubjdet.TabIndex = 20;
            this.bttndelsubjdet.Text = "Delete";
            this.bttndelsubjdet.UseVisualStyleBackColor = true;
            this.bttndelsubjdet.Click += new System.EventHandler(this.bttndelsubjdet_Click);
            // 
            // subjdetsear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 644);
            this.Controls.Add(this.bttndelsubjdet);
            this.Controls.Add(this.bttneditsubjdet);
            this.Controls.Add(this.bttndispsubjdet);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ssubjtype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ssyllabus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textsubjcr);
            this.Controls.Add(this.sclass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scourse);
            this.Controls.Add(this.label3);
            this.Name = "subjdetsear";
            this.Text = "Subject Retrieval/Edit";
            this.Load += new System.EventHandler(this.subjdetsear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sclass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox scourse;
        private System.Windows.Forms.TextBox textsubjcr;
        private System.Windows.Forms.ComboBox ssyllabus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ssubjtype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttndispsubjdet;
        private System.Windows.Forms.Button bttneditsubjdet;
        private System.Windows.Forms.Button bttndelsubjdet;
    }
}