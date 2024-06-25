using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace APMS
{
    public partial class login : Form
    {        
        SqlCommand cmd;
        SqlDataReader dr;
        bool s;
        public login(bool setp)
        {
            InitializeComponent();
            if (setp)
            {
                bttnsubmit.Text = "Save";
                this.Text = "Set Password";
            }
            s = setp;
        }

        private void bttnsubmit_Click(object sender, EventArgs e)
        {
            if (s)
            {
                  cmd = new SqlCommand("select password from user_login where user_name='" + textuname.Text + "'", mainapms.con);
                  cmd.CommandText = "Update user_login set password='" + textpswd.Text + "' where user_name='" + textuname.Text + "'";
                  cmd.ExecuteNonQuery();
                  this.Close();
            }
            else
            {
                cmd = new SqlCommand("select password from user_login where user_name='" + textuname.Text + "'",mainapms.con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (textpswd.Text == dr["password"].ToString())
                    {
                        dr.Close();
                        mainapms.cuser = textuname.Text;
                        this.Close();
                        Program.apms.Enabled = true;
                        Program.apms.start();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Invalid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textpswd.Text = "";
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Invalid user name and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textpswd.Text = "";
                    textuname.Text = "";
                } 
            }
        }

        private void login_Load(object sender, EventArgs e)
        {           
            if (s)
            {
                if (mainapms.cusert == "Admin")
                    textuname.Text = "admin";
                else
                {
                    textuname.Text = mainapms.cuser;
                    textuname.Enabled = false;
                }
            }
        }

        private void bttncancel_Click(object sender, EventArgs e)
        {
            if (s)
                this.Close();
            else
                Application.Exit();
        }      
    }
}
