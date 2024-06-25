namespace APMS
{
    partial class eventsearch
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
            this.eventstdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.eventenddate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textename = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttndelevents = new System.Windows.Forms.Button();
            this.bttndispevents = new System.Windows.Forms.Button();
            this.bttnedev = new System.Windows.Forms.Button();
            this.sEvttype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event Type";
            // 
            // eventstdate
            // 
            this.eventstdate.Location = new System.Drawing.Point(658, 21);
            this.eventstdate.Name = "eventstdate";
            this.eventstdate.Size = new System.Drawing.Size(200, 20);
            this.eventstdate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Date";
            // 
            // eventenddate
            // 
            this.eventenddate.Location = new System.Drawing.Point(658, 66);
            this.eventenddate.Name = "eventenddate";
            this.eventenddate.Size = new System.Drawing.Size(200, 20);
            this.eventenddate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Search Criteria of Event Name";
            // 
            // textename
            // 
            this.textename.Location = new System.Drawing.Point(215, 58);
            this.textename.Name = "textename";
            this.textename.Size = new System.Drawing.Size(311, 20);
            this.textename.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1092, 465);
            this.dataGridView1.TabIndex = 23;
            // 
            // bttndelevents
            // 
            this.bttndelevents.Location = new System.Drawing.Point(923, 67);
            this.bttndelevents.Name = "bttndelevents";
            this.bttndelevents.Size = new System.Drawing.Size(154, 23);
            this.bttndelevents.TabIndex = 24;
            this.bttndelevents.Text = "Delete Event Details";
            this.bttndelevents.UseVisualStyleBackColor = true;
            this.bttndelevents.Click += new System.EventHandler(this.bttndelevents_Click);
            // 
            // bttndispevents
            // 
            this.bttndispevents.Location = new System.Drawing.Point(923, 9);
            this.bttndispevents.Name = "bttndispevents";
            this.bttndispevents.Size = new System.Drawing.Size(154, 23);
            this.bttndispevents.TabIndex = 25;
            this.bttndispevents.Text = "Display Event Details";
            this.bttndispevents.UseVisualStyleBackColor = true;
            this.bttndispevents.Click += new System.EventHandler(this.bttndispevents_Click);
            // 
            // bttnedev
            // 
            this.bttnedev.Location = new System.Drawing.Point(923, 38);
            this.bttnedev.Name = "bttnedev";
            this.bttnedev.Size = new System.Drawing.Size(154, 23);
            this.bttnedev.TabIndex = 26;
            this.bttnedev.Text = "Edit Event Details";
            this.bttnedev.UseVisualStyleBackColor = true;
            this.bttnedev.Click += new System.EventHandler(this.bttnedev_Click);
            // 
            // sEvttype
            // 
            this.sEvttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sEvttype.FormattingEnabled = true;
            this.sEvttype.Items.AddRange(new object[] {
            "Holiday",
            "General",
            "All"});
            this.sEvttype.Location = new System.Drawing.Point(215, 18);
            this.sEvttype.Name = "sEvttype";
            this.sEvttype.Size = new System.Drawing.Size(200, 21);
            this.sEvttype.TabIndex = 27;
            // 
            // eventsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 617);
            this.Controls.Add(this.sEvttype);
            this.Controls.Add(this.bttnedev);
            this.Controls.Add(this.bttndispevents);
            this.Controls.Add(this.bttndelevents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eventenddate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eventstdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "eventsearch";
            this.Text = "Search/Retrieve Events";
            this.Load += new System.EventHandler(this.eventsearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker eventstdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker eventenddate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textename;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttndelevents;
        private System.Windows.Forms.Button bttndispevents;
        private System.Windows.Forms.Button bttnedev;
        private System.Windows.Forms.ComboBox sEvttype;
    }
}