namespace APMS
{
    partial class attdretsess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sclass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scourse = new System.Windows.Forms.ComboBox();
            this.textssno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.optconsdate = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timesess = new System.Windows.Forms.DateTimePicker();
            this.datesess = new System.Windows.Forms.DateTimePicker();
            this.optconstime = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.presabslbl = new System.Windows.Forms.Label();
            this.optpresstud = new System.Windows.Forms.CheckBox();
            this.bttndispstudr = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.bttndeldatsess = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ssyllabus = new System.Windows.Forms.ComboBox();
            this.sbatch = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ssubj = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sclass
            // 
            this.sclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sclass.FormattingEnabled = true;
            this.sclass.Location = new System.Drawing.Point(157, 112);
            this.sclass.Name = "sclass";
            this.sclass.Size = new System.Drawing.Size(121, 21);
            this.sclass.TabIndex = 13;
            this.sclass.SelectedIndexChanged += new System.EventHandler(this.sclass_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Select course";
            // 
            // scourse
            // 
            this.scourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scourse.FormattingEnabled = true;
            this.scourse.Location = new System.Drawing.Point(157, 12);
            this.scourse.Name = "scourse";
            this.scourse.Size = new System.Drawing.Size(121, 21);
            this.scourse.TabIndex = 9;
            this.scourse.SelectedIndexChanged += new System.EventHandler(this.scourse_SelectedIndexChanged);
            // 
            // textssno
            // 
            this.textssno.Location = new System.Drawing.Point(157, 270);
            this.textssno.Name = "textssno";
            this.textssno.Size = new System.Drawing.Size(121, 20);
            this.textssno.TabIndex = 18;
            this.textssno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textssno_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Enter lecture session no";
            // 
            // optconsdate
            // 
            this.optconsdate.AutoSize = true;
            this.optconsdate.Location = new System.Drawing.Point(50, 307);
            this.optconsdate.Name = "optconsdate";
            this.optconsdate.Size = new System.Drawing.Size(93, 17);
            this.optconsdate.TabIndex = 19;
            this.optconsdate.Text = "Consider Date";
            this.optconsdate.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Optional time";
            // 
            // timesess
            // 
            this.timesess.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timesess.Location = new System.Drawing.Point(151, 399);
            this.timesess.Name = "timesess";
            this.timesess.Size = new System.Drawing.Size(121, 20);
            this.timesess.TabIndex = 22;
            // 
            // datesess
            // 
            this.datesess.Location = new System.Drawing.Point(143, 335);
            this.datesess.Name = "datesess";
            this.datesess.Size = new System.Drawing.Size(200, 20);
            this.datesess.TabIndex = 21;
            // 
            // optconstime
            // 
            this.optconstime.AutoSize = true;
            this.optconstime.Location = new System.Drawing.Point(50, 376);
            this.optconstime.Name = "optconstime";
            this.optconstime.Size = new System.Drawing.Size(93, 17);
            this.optconstime.TabIndex = 20;
            this.optconstime.Text = "Consider Time";
            this.optconstime.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Enter date";
            // 
            // presabslbl
            // 
            this.presabslbl.AutoSize = true;
            this.presabslbl.Location = new System.Drawing.Point(362, 6);
            this.presabslbl.Name = "presabslbl";
            this.presabslbl.Size = new System.Drawing.Size(123, 13);
            this.presabslbl.TabIndex = 27;
            this.presabslbl.Text = "Present/absent students";
            // 
            // optpresstud
            // 
            this.optpresstud.AutoSize = true;
            this.optpresstud.Location = new System.Drawing.Point(50, 433);
            this.optpresstud.Name = "optpresstud";
            this.optpresstud.Size = new System.Drawing.Size(134, 17);
            this.optpresstud.TabIndex = 28;
            this.optpresstud.Text = "Show present students";
            this.optpresstud.UseVisualStyleBackColor = true;
            // 
            // bttndispstudr
            // 
            this.bttndispstudr.Location = new System.Drawing.Point(17, 456);
            this.bttndispstudr.Name = "bttndispstudr";
            this.bttndispstudr.Size = new System.Drawing.Size(152, 23);
            this.bttndispstudr.TabIndex = 29;
            this.bttndispstudr.Text = "Show student roll nos";
            this.bttndispstudr.UseVisualStyleBackColor = true;
            this.bttndispstudr.Click += new System.EventHandler(this.bttndispstudr_Click);
            // 
            // dataGridView
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(365, 22);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Size = new System.Drawing.Size(388, 459);
            this.dataGridView.TabIndex = 30;
            // 
            // bttndeldatsess
            // 
            this.bttndeldatsess.Location = new System.Drawing.Point(190, 456);
            this.bttndeldatsess.Name = "bttndeldatsess";
            this.bttndeldatsess.Size = new System.Drawing.Size(153, 23);
            this.bttndeldatsess.TabIndex = 31;
            this.bttndeldatsess.Text = "Delete data of session";
            this.bttndeldatsess.UseVisualStyleBackColor = true;
            this.bttndeldatsess.Click += new System.EventHandler(this.bttndeldatsess_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Select syllabus";
            // 
            // ssyllabus
            // 
            this.ssyllabus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssyllabus.FormattingEnabled = true;
            this.ssyllabus.Location = new System.Drawing.Point(157, 61);
            this.ssyllabus.Name = "ssyllabus";
            this.ssyllabus.Size = new System.Drawing.Size(121, 21);
            this.ssyllabus.TabIndex = 34;
            this.ssyllabus.SelectedIndexChanged += new System.EventHandler(this.ssyllabus_SelectedIndexChanged);
            // 
            // sbatch
            // 
            this.sbatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sbatch.FormattingEnabled = true;
            this.sbatch.Location = new System.Drawing.Point(157, 217);
            this.sbatch.Name = "sbatch";
            this.sbatch.Size = new System.Drawing.Size(121, 21);
            this.sbatch.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Select batch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select subject";
            // 
            // ssubj
            // 
            this.ssubj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssubj.FormattingEnabled = true;
            this.ssubj.Location = new System.Drawing.Point(157, 163);
            this.ssubj.Name = "ssubj";
            this.ssubj.Size = new System.Drawing.Size(121, 21);
            this.ssubj.TabIndex = 14;
            this.ssubj.SelectedIndexChanged += new System.EventHandler(this.ssubj_SelectedIndexChanged);
            // 
            // attdretsess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 493);
            this.Controls.Add(this.sbatch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ssyllabus);
            this.Controls.Add(this.bttndeldatsess);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bttndispstudr);
            this.Controls.Add(this.optpresstud);
            this.Controls.Add(this.presabslbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timesess);
            this.Controls.Add(this.datesess);
            this.Controls.Add(this.optconstime);
            this.Controls.Add(this.optconsdate);
            this.Controls.Add(this.textssno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ssubj);
            this.Controls.Add(this.sclass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scourse);
            this.Name = "attdretsess";
            this.Text = "Attendance Retrieval of a lecture session";
            this.Load += new System.EventHandler(this.attdretsess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sclass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox scourse;
        private System.Windows.Forms.TextBox textssno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox optconsdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timesess;
        private System.Windows.Forms.DateTimePicker datesess;
        private System.Windows.Forms.CheckBox optconstime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label presabslbl;
        private System.Windows.Forms.CheckBox optpresstud;
        private System.Windows.Forms.Button bttndispstudr;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button bttndeldatsess;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ssyllabus;
        private System.Windows.Forms.ComboBox sbatch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ssubj;

    }
}