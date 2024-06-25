namespace APMS
{
    partial class attdpercret
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
            this.optallstud = new System.Windows.Forms.RadioButton();
            this.optlethan = new System.Windows.Forms.RadioButton();
            this.textperc = new System.Windows.Forms.TextBox();
            this.bttnpercattd = new System.Windows.Forms.Button();
            this.sbatch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ssyllabus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ssubj = new System.Windows.Forms.ComboBox();
            this.sclass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scourse = new System.Windows.Forms.ComboBox();
            this.textd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // optallstud
            // 
            this.optallstud.AutoSize = true;
            this.optallstud.Location = new System.Drawing.Point(60, 208);
            this.optallstud.Name = "optallstud";
            this.optallstud.Size = new System.Drawing.Size(36, 17);
            this.optallstud.TabIndex = 15;
            this.optallstud.TabStop = true;
            this.optallstud.Text = "All";
            this.optallstud.UseVisualStyleBackColor = true;
            this.optallstud.CheckedChanged += new System.EventHandler(this.optallstud_CheckedChanged);
            // 
            // optlethan
            // 
            this.optlethan.AutoSize = true;
            this.optlethan.Location = new System.Drawing.Point(60, 231);
            this.optlethan.Name = "optlethan";
            this.optlethan.Size = new System.Drawing.Size(31, 17);
            this.optlethan.TabIndex = 17;
            this.optlethan.TabStop = true;
            this.optlethan.Text = "<";
            this.optlethan.UseVisualStyleBackColor = true;
            // 
            // textperc
            // 
            this.textperc.Enabled = false;
            this.textperc.Location = new System.Drawing.Point(109, 231);
            this.textperc.MaxLength = 5;
            this.textperc.Name = "textperc";
            this.textperc.Size = new System.Drawing.Size(59, 20);
            this.textperc.TabIndex = 18;
            // 
            // bttnpercattd
            // 
            this.bttnpercattd.Location = new System.Drawing.Point(44, 273);
            this.bttnpercattd.Name = "bttnpercattd";
            this.bttnpercattd.Size = new System.Drawing.Size(136, 23);
            this.bttnpercattd.TabIndex = 21;
            this.bttnpercattd.Text = "Show % attendance";
            this.bttnpercattd.UseVisualStyleBackColor = true;
            this.bttnpercattd.Click += new System.EventHandler(this.bttnpercattd_Click);
            // 
            // sbatch
            // 
            this.sbatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sbatch.FormattingEnabled = true;
            this.sbatch.Location = new System.Drawing.Point(138, 176);
            this.sbatch.Name = "sbatch";
            this.sbatch.Size = new System.Drawing.Size(121, 21);
            this.sbatch.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Select batch";
            // 
            // ssyllabus
            // 
            this.ssyllabus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssyllabus.FormattingEnabled = true;
            this.ssyllabus.Location = new System.Drawing.Point(138, 52);
            this.ssyllabus.Name = "ssyllabus";
            this.ssyllabus.Size = new System.Drawing.Size(121, 21);
            this.ssyllabus.TabIndex = 42;
            this.ssyllabus.SelectedIndexChanged += new System.EventHandler(this.ssyllabus_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Select syllabus";
            // 
            // ssubj
            // 
            this.ssubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssubj.FormattingEnabled = true;
            this.ssubj.Location = new System.Drawing.Point(138, 134);
            this.ssubj.Name = "ssubj";
            this.ssubj.Size = new System.Drawing.Size(121, 21);
            this.ssubj.TabIndex = 40;
            this.ssubj.SelectedIndexChanged += new System.EventHandler(this.ssubj_SelectedIndexChanged);
            // 
            // sclass
            // 
            this.sclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sclass.FormattingEnabled = true;
            this.sclass.Location = new System.Drawing.Point(138, 91);
            this.sclass.Name = "sclass";
            this.sclass.Size = new System.Drawing.Size(121, 21);
            this.sclass.TabIndex = 39;
            this.sclass.SelectedIndexChanged += new System.EventHandler(this.sclass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Select subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Select class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Select course";
            // 
            // scourse
            // 
            this.scourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scourse.FormattingEnabled = true;
            this.scourse.Location = new System.Drawing.Point(138, 9);
            this.scourse.Name = "scourse";
            this.scourse.Size = new System.Drawing.Size(121, 21);
            this.scourse.TabIndex = 35;
            this.scourse.SelectedIndexChanged += new System.EventHandler(this.scourse_SelectedIndexChanged);
            // 
            // textd
            // 
            this.textd.AcceptsReturn = true;
            this.textd.AcceptsTab = true;
            this.textd.Location = new System.Drawing.Point(276, 12);
            this.textd.Multiline = true;
            this.textd.Name = "textd";
            this.textd.ReadOnly = true;
            this.textd.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textd.Size = new System.Drawing.Size(574, 449);
            this.textd.TabIndex = 45;
            // 
            // attdpercret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 486);
            this.Controls.Add(this.textd);
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
            this.Controls.Add(this.bttnpercattd);
            this.Controls.Add(this.textperc);
            this.Controls.Add(this.optlethan);
            this.Controls.Add(this.optallstud);
            this.Name = "attdpercret";
            this.Text = "Retrieval of % attendance";
            this.Load += new System.EventHandler(this.attdpercret_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optallstud;
        private System.Windows.Forms.RadioButton optlethan;
        private System.Windows.Forms.TextBox textperc;
        private System.Windows.Forms.Button bttnpercattd;
        private System.Windows.Forms.ComboBox sbatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ssyllabus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ssubj;
        private System.Windows.Forms.ComboBox sclass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox scourse;
        private System.Windows.Forms.TextBox textd;
    }
}