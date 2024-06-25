namespace APMS
{
    partial class attdretstud
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
            this.textrno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sclass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewpres = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewabs = new System.Windows.Forms.DataGridView();
            this.bttnattddet = new System.Windows.Forms.Button();
            this.ssubj = new System.Windows.Forms.ComboBox();
            this.labelperc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelstname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewabs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter roll no";
            // 
            // textrno
            // 
            this.textrno.Location = new System.Drawing.Point(110, 21);
            this.textrno.Name = "textrno";
            this.textrno.Size = new System.Drawing.Size(150, 20);
            this.textrno.TabIndex = 2;
            this.textrno.TextChanged += new System.EventHandler(this.textrno_TextChanged);
            this.textrno.Leave += new System.EventHandler(this.textrno_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter class";
            // 
            // sclass
            // 
            this.sclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sclass.FormattingEnabled = true;
            this.sclass.Location = new System.Drawing.Point(606, 16);
            this.sclass.Name = "sclass";
            this.sclass.Size = new System.Drawing.Size(54, 21);
            this.sclass.TabIndex = 4;
            this.sclass.SelectedIndexChanged += new System.EventHandler(this.sclass_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select subject";
            // 
            // dataGridViewpres
            // 
            this.dataGridViewpres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpres.Location = new System.Drawing.Point(33, 157);
            this.dataGridViewpres.Name = "dataGridViewpres";
            this.dataGridViewpres.ReadOnly = true;
            this.dataGridViewpres.Size = new System.Drawing.Size(445, 452);
            this.dataGridViewpres.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Present Lecture Sessions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(517, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Absent Lecture Sessions";
            // 
            // dataGridViewabs
            // 
            this.dataGridViewabs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewabs.Location = new System.Drawing.Point(520, 157);
            this.dataGridViewabs.Name = "dataGridViewabs";
            this.dataGridViewabs.ReadOnly = true;
            this.dataGridViewabs.Size = new System.Drawing.Size(445, 452);
            this.dataGridViewabs.TabIndex = 11;
            // 
            // bttnattddet
            // 
            this.bttnattddet.Location = new System.Drawing.Point(299, 92);
            this.bttnattddet.Name = "bttnattddet";
            this.bttnattddet.Size = new System.Drawing.Size(150, 27);
            this.bttnattddet.TabIndex = 14;
            this.bttnattddet.Text = "Display attendance details";
            this.bttnattddet.UseVisualStyleBackColor = true;
            this.bttnattddet.Click += new System.EventHandler(this.bttnattddet_Click);
            // 
            // ssubj
            // 
            this.ssubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssubj.FormattingEnabled = true;
            this.ssubj.Location = new System.Drawing.Point(606, 54);
            this.ssubj.Name = "ssubj";
            this.ssubj.Size = new System.Drawing.Size(238, 21);
            this.ssubj.TabIndex = 15;
            // 
            // labelperc
            // 
            this.labelperc.AutoSize = true;
            this.labelperc.Location = new System.Drawing.Point(748, 99);
            this.labelperc.Name = "labelperc";
            this.labelperc.Size = new System.Drawing.Size(73, 13);
            this.labelperc.TabIndex = 16;
            this.labelperc.Text = "Percentage %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(30, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 44;
            this.label10.Text = "Name";
            // 
            // labelstname
            // 
            this.labelstname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelstname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelstname.Location = new System.Drawing.Point(110, 59);
            this.labelstname.Name = "labelstname";
            this.labelstname.Size = new System.Drawing.Size(268, 20);
            this.labelstname.TabIndex = 43;
            // 
            // attdretstud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 621);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelstname);
            this.Controls.Add(this.labelperc);
            this.Controls.Add(this.ssubj);
            this.Controls.Add(this.bttnattddet);
            this.Controls.Add(this.dataGridViewabs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewpres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sclass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textrno);
            this.Controls.Add(this.label1);
            this.Name = "attdretstud";
            this.Text = "Attendance retrieval of a student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewabs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textrno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sclass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewpres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewabs;
        private System.Windows.Forms.Button bttnattddet;
        private System.Windows.Forms.ComboBox ssubj;
        private System.Windows.Forms.Label labelperc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelstname;
    }
}