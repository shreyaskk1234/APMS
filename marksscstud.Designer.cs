namespace APMS
{
    partial class marksscstud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marksscstud));
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelstname = new System.Windows.Forms.Label();
            this.textrno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bttnsave = new System.Windows.Forms.Button();
            this.bttndisp = new System.Windows.Forms.Button();
            this.textclass = new System.Windows.Forms.TextBox();
            this.bttndel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // labelstname
            // 
            this.labelstname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.labelstname, "labelstname");
            this.labelstname.Name = "labelstname";
            // 
            // textrno
            // 
            resources.ApplyResources(this.textrno, "textrno");
            this.textrno.Name = "textrno";
            this.textrno.TextChanged += new System.EventHandler(this.textrno_TextChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // bttnsave
            // 
            resources.ApplyResources(this.bttnsave, "bttnsave");
            this.bttnsave.Name = "bttnsave";
            this.bttnsave.UseVisualStyleBackColor = true;
            this.bttnsave.Click += new System.EventHandler(this.bttnsave_Click);
            // 
            // bttndisp
            // 
            resources.ApplyResources(this.bttndisp, "bttndisp");
            this.bttndisp.Name = "bttndisp";
            this.bttndisp.UseVisualStyleBackColor = true;
            this.bttndisp.Click += new System.EventHandler(this.bttndisp_Click);
            // 
            // textclass
            // 
            resources.ApplyResources(this.textclass, "textclass");
            this.textclass.Name = "textclass";
            this.textclass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tmkeypress);
            // 
            // bttndel
            // 
            resources.ApplyResources(this.bttndel, "bttndel");
            this.bttndel.Name = "bttndel";
            this.bttndel.UseVisualStyleBackColor = true;
            this.bttndel.Click += new System.EventHandler(this.bttndel_Click);
            // 
            // marksscstud
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttndel);
            this.Controls.Add(this.textclass);
            this.Controls.Add(this.bttndisp);
            this.Controls.Add(this.bttnsave);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelstname);
            this.Controls.Add(this.textrno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Name = "marksscstud";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.marksscrecstud_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelstname;
        private System.Windows.Forms.TextBox textrno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttnsave;
        private System.Windows.Forms.Button bttndisp;
        private System.Windows.Forms.TextBox textclass;
        private System.Windows.Forms.Button bttndel;
    }
}