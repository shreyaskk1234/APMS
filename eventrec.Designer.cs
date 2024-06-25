namespace APMS
{
    partial class eventrec
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
            this.sEvttype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eventdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.timeevent = new System.Windows.Forms.DateTimePicker();
            this.optconstime = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textedesc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sremtype = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textremtgap = new System.Windows.Forms.TextBox();
            this.bttnrecevent = new System.Windows.Forms.Button();
            this.bttnres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Type";
            // 
            // sEvttype
            // 
            this.sEvttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sEvttype.FormattingEnabled = true;
            this.sEvttype.Items.AddRange(new object[] {
            "Holiday",
            "General"});
            this.sEvttype.Location = new System.Drawing.Point(136, 11);
            this.sEvttype.Name = "sEvttype";
            this.sEvttype.Size = new System.Drawing.Size(200, 21);
            this.sEvttype.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // eventdate
            // 
            this.eventdate.Location = new System.Drawing.Point(136, 53);
            this.eventdate.Name = "eventdate";
            this.eventdate.Size = new System.Drawing.Size(200, 20);
            this.eventdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Optional Time";
            // 
            // timeevent
            // 
            this.timeevent.Enabled = false;
            this.timeevent.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeevent.Location = new System.Drawing.Point(136, 121);
            this.timeevent.Name = "timeevent";
            this.timeevent.Size = new System.Drawing.Size(121, 20);
            this.timeevent.TabIndex = 15;
            // 
            // optconstime
            // 
            this.optconstime.AutoSize = true;
            this.optconstime.Location = new System.Drawing.Point(136, 89);
            this.optconstime.Name = "optconstime";
            this.optconstime.Size = new System.Drawing.Size(93, 17);
            this.optconstime.TabIndex = 14;
            this.optconstime.Text = "Consider Time";
            this.optconstime.UseVisualStyleBackColor = true;
            this.optconstime.CheckedChanged += new System.EventHandler(this.optconstime_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Event Name";
            // 
            // textename
            // 
            this.textename.Location = new System.Drawing.Point(136, 162);
            this.textename.Name = "textename";
            this.textename.Size = new System.Drawing.Size(347, 20);
            this.textename.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Event Description";
            // 
            // textedesc
            // 
            this.textedesc.Location = new System.Drawing.Point(136, 205);
            this.textedesc.Multiline = true;
            this.textedesc.Name = "textedesc";
            this.textedesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textedesc.Size = new System.Drawing.Size(347, 112);
            this.textedesc.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Reminder Type";
            // 
            // sremtype
            // 
            this.sremtype.FormattingEnabled = true;
            this.sremtype.Items.AddRange(new object[] {
            "Startup",
            "Per x days",
            "No reminder"});
            this.sremtype.Location = new System.Drawing.Point(136, 334);
            this.sremtype.Name = "sremtype";
            this.sremtype.Size = new System.Drawing.Size(121, 43);
            this.sremtype.TabIndex = 22;
            this.sremtype.SelectedIndexChanged += new System.EventHandler(this.sremtype_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Reminder Time Gap";
            // 
            // textremtgap
            // 
            this.textremtgap.Enabled = false;
            this.textremtgap.Location = new System.Drawing.Point(136, 405);
            this.textremtgap.Name = "textremtgap";
            this.textremtgap.Size = new System.Drawing.Size(55, 20);
            this.textremtgap.TabIndex = 24;
            // 
            // bttnrecevent
            // 
            this.bttnrecevent.Location = new System.Drawing.Point(136, 436);
            this.bttnrecevent.Name = "bttnrecevent";
            this.bttnrecevent.Size = new System.Drawing.Size(110, 23);
            this.bttnrecevent.TabIndex = 25;
            this.bttnrecevent.Text = "Record/Save";
            this.bttnrecevent.UseVisualStyleBackColor = true;
            this.bttnrecevent.Click += new System.EventHandler(this.bttnrecevent_Click);
            // 
            // bttnres
            // 
            this.bttnres.Location = new System.Drawing.Point(299, 436);
            this.bttnres.Name = "bttnres";
            this.bttnres.Size = new System.Drawing.Size(82, 23);
            this.bttnres.TabIndex = 26;
            this.bttnres.Text = "Reset";
            this.bttnres.UseVisualStyleBackColor = true;
            this.bttnres.Click += new System.EventHandler(this.bttnres_Click);
            // 
            // eventrec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 471);
            this.Controls.Add(this.bttnres);
            this.Controls.Add(this.bttnrecevent);
            this.Controls.Add(this.textremtgap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.sremtype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textedesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeevent);
            this.Controls.Add(this.optconstime);
            this.Controls.Add(this.eventdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sEvttype);
            this.Controls.Add(this.label1);
            this.Name = "eventrec";
            this.Text = "Recording of details of event/holiday";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sEvttype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker eventdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker timeevent;
        private System.Windows.Forms.CheckBox optconstime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textedesc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox sremtype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textremtgap;
        private System.Windows.Forms.Button bttnrecevent;
        private System.Windows.Forms.Button bttnres;
    }
}