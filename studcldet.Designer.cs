namespace APMS
{
    partial class studcldet
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
            this.sbatch = new System.Windows.Forms.ComboBox();
            this.dateclssadm = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scourse = new System.Windows.Forms.ComboBox();
            this.sclass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnsave = new System.Windows.Forms.Button();
            this.soptsubj = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textexrno = new System.Windows.Forms.TextBox();
            this.textoptsrno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.opteditm = new System.Windows.Forms.CheckBox();
            this.bttncladdsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Batch";
            // 
            // sbatch
            // 
            this.sbatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sbatch.FormattingEnabled = true;
            this.sbatch.Location = new System.Drawing.Point(169, 54);
            this.sbatch.Name = "sbatch";
            this.sbatch.Size = new System.Drawing.Size(121, 21);
            this.sbatch.TabIndex = 1;
            // 
            // dateclssadm
            // 
            this.dateclssadm.Location = new System.Drawing.Point(169, 150);
            this.dateclssadm.Name = "dateclssadm";
            this.dateclssadm.Size = new System.Drawing.Size(200, 20);
            this.dateclssadm.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Select class admission date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Course";
            // 
            // scourse
            // 
            this.scourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scourse.FormattingEnabled = true;
            this.scourse.Location = new System.Drawing.Point(169, 12);
            this.scourse.Name = "scourse";
            this.scourse.Size = new System.Drawing.Size(121, 21);
            this.scourse.TabIndex = 18;
            this.scourse.SelectedIndexChanged += new System.EventHandler(this.scourse_SelectedIndexChanged);
            // 
            // sclass
            // 
            this.sclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sclass.FormattingEnabled = true;
            this.sclass.Location = new System.Drawing.Point(169, 98);
            this.sclass.Name = "sclass";
            this.sclass.Size = new System.Drawing.Size(121, 21);
            this.sclass.TabIndex = 26;
            this.sclass.SelectedIndexChanged += new System.EventHandler(this.sclass_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Class";
            // 
            // bttnsave
            // 
            this.bttnsave.Location = new System.Drawing.Point(240, 600);
            this.bttnsave.Name = "bttnsave";
            this.bttnsave.Size = new System.Drawing.Size(84, 29);
            this.bttnsave.TabIndex = 28;
            this.bttnsave.Text = "Save";
            this.bttnsave.UseVisualStyleBackColor = true;
            this.bttnsave.Click += new System.EventHandler(this.bttnsave_Click);
            // 
            // soptsubj
            // 
            this.soptsubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.soptsubj.FormattingEnabled = true;
            this.soptsubj.Location = new System.Drawing.Point(169, 405);
            this.soptsubj.Name = "soptsubj";
            this.soptsubj.Size = new System.Drawing.Size(187, 21);
            this.soptsubj.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Opt Subject(if any)";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(42, 490);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 49);
            this.label3.TabIndex = 31;
            this.label3.Text = "List of student roll nos of optional subject";
            // 
            // textexrno
            // 
            this.textexrno.Location = new System.Drawing.Point(169, 204);
            this.textexrno.Multiline = true;
            this.textexrno.Name = "textexrno";
            this.textexrno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textexrno.Size = new System.Drawing.Size(345, 125);
            this.textexrno.TabIndex = 33;
            // 
            // textoptsrno
            // 
            this.textoptsrno.Location = new System.Drawing.Point(169, 452);
            this.textoptsrno.Multiline = true;
            this.textoptsrno.Name = "textoptsrno";
            this.textoptsrno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textoptsrno.Size = new System.Drawing.Size(345, 125);
            this.textoptsrno.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Exclude roll nos";
            // 
            // opteditm
            // 
            this.opteditm.AutoSize = true;
            this.opteditm.Location = new System.Drawing.Point(33, 579);
            this.opteditm.Name = "opteditm";
            this.opteditm.Size = new System.Drawing.Size(74, 17);
            this.opteditm.TabIndex = 38;
            this.opteditm.Text = "Edit Mode";
            this.opteditm.UseVisualStyleBackColor = true;
            // 
            // bttncladdsave
            // 
            this.bttncladdsave.Location = new System.Drawing.Point(231, 353);
            this.bttncladdsave.Name = "bttncladdsave";
            this.bttncladdsave.Size = new System.Drawing.Size(84, 29);
            this.bttncladdsave.TabIndex = 39;
            this.bttncladdsave.Text = "Save";
            this.bttncladdsave.UseVisualStyleBackColor = true;
            this.bttncladdsave.Click += new System.EventHandler(this.bttncladdsave_Click);
            // 
            // studcldet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 673);
            this.Controls.Add(this.bttncladdsave);
            this.Controls.Add(this.opteditm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textoptsrno);
            this.Controls.Add(this.textexrno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soptsubj);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bttnsave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sclass);
            this.Controls.Add(this.scourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateclssadm);
            this.Controls.Add(this.sbatch);
            this.Controls.Add(this.label1);
            this.Name = "studcldet";
            this.Text = "Student class details";
            this.Load += new System.EventHandler(this.studcldet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sbatch;
        private System.Windows.Forms.DateTimePicker dateclssadm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox scourse;
        private System.Windows.Forms.ComboBox sclass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnsave;
        private System.Windows.Forms.ComboBox soptsubj;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textexrno;
        private System.Windows.Forms.TextBox textoptsrno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox opteditm;
        private System.Windows.Forms.Button bttncladdsave;
    }
}