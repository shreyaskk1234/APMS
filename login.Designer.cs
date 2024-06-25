namespace APMS
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bttncancel = new System.Windows.Forms.Button();
            this.bttnsubmit = new System.Windows.Forms.Button();
            this.textpswd = new System.Windows.Forms.TextBox();
            this.textuname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttncancel
            // 
            this.bttncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttncancel.Location = new System.Drawing.Point(145, 114);
            this.bttncancel.Name = "bttncancel";
            this.bttncancel.Size = new System.Drawing.Size(61, 31);
            this.bttncancel.TabIndex = 17;
            this.bttncancel.Text = "Cancel";
            this.bttncancel.UseVisualStyleBackColor = true;
            this.bttncancel.Click += new System.EventHandler(this.bttncancel_Click);
            // 
            // bttnsubmit
            // 
            this.bttnsubmit.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.bttnsubmit.Location = new System.Drawing.Point(57, 114);
            this.bttnsubmit.Name = "bttnsubmit";
            this.bttnsubmit.Size = new System.Drawing.Size(61, 31);
            this.bttnsubmit.TabIndex = 16;
            this.bttnsubmit.Text = "Submit";
            this.bttnsubmit.UseVisualStyleBackColor = true;
            this.bttnsubmit.Click += new System.EventHandler(this.bttnsubmit_Click);
            // 
            // textpswd
            // 
            this.textpswd.Location = new System.Drawing.Point(133, 65);
            this.textpswd.MaxLength = 25;
            this.textpswd.Name = "textpswd";
            this.textpswd.PasswordChar = '*';
            this.textpswd.Size = new System.Drawing.Size(118, 20);
            this.textpswd.TabIndex = 15;
            // 
            // textuname
            // 
            this.textuname.Location = new System.Drawing.Point(133, 23);
            this.textuname.MaxLength = 10;
            this.textuname.Name = "textuname";
            this.textuname.Size = new System.Drawing.Size(118, 20);
            this.textuname.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Enter password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AcceptButton = this.bttnsubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bttncancel;
            this.ClientSize = new System.Drawing.Size(454, 186);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttncancel);
            this.Controls.Add(this.bttnsubmit);
            this.Controls.Add(this.textpswd);
            this.Controls.Add(this.textuname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "login";
            this.Text = "User Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttncancel;
        private System.Windows.Forms.Button bttnsubmit;
        private System.Windows.Forms.TextBox textpswd;
        private System.Windows.Forms.TextBox textuname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}