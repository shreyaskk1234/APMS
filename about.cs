using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace APMS
{
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void bttnok_Click(object sender, EventArgs e)
        {
            Program.apms.Enabled = true;
            this.Close();           
        }
    }
}
