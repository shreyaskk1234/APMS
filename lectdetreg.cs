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
    public partial class lectdetreg : Form
    {
        
        SqlCommand cmd;
        SqlDataReader dr;
        string s;
        public lectdetreg()
        {
            InitializeComponent();
            
            
        }

        private void lectaddreg_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select distinct course from subj_details", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                scourse.Items.Add(dr["course"].ToString());
            }
            dr.Close();
            cmd = new SqlCommand("select lecturer_id from lecturer_det", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                slectid.Items.Add(dr["lecturer_id"].ToString());
            }
            dr.Close();
            if (mainapms.cusert == "Student" | mainapms.cusert == "Lecturer")
            {
                bttnreglect.Enabled = false;
                bttnaddsubj.Enabled = false;
                bttnclearsubj.Enabled = false;
                bttndellect.Enabled = false;
                bttnremsubj.Enabled = false;
            }
        }

        private void scourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select distinct syllabus from subj_details where course='" + scourse.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ssyllabus.Items.Add(dr["syllabus"].ToString());
            }
            dr.Close();
        }

        private void sclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ssubj.Items.Clear();
            try
            {
                cmd = new SqlCommand("select distinct subj_name from subj_details where class_of_subj=" + int.Parse(sclass.Text) + " and syllabus='" + ssyllabus.Text + "' and course='" + scourse.Text + "'", mainapms.con);
                dr = cmd.ExecuteReader();
            }
            catch (Exception)
            { }
            while (dr.Read())
            {
                ssubj.Items.Add(dr["subj_name"].ToString());
            }
            dr.Close();
        }

        private void ssyllabus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select distinct class_of_subj from subj_details where syllabus='" + ssyllabus.Text + "' and course='" + scourse.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sclass.Items.Add(dr["class_of_subj"].ToString());
            }
            dr.Close();
        }

        private void bttnreglect_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from lecturer_det", mainapms.con);
            SqlCommand cmd2 = new SqlCommand("select * from lecturer_det", mainapms.con);
            try
            {
                cmd.CommandText = "Insert into lecturer_det(lecturer_id,l_name) values('" + slectid.Text + "','" + textlname.Text + "')";
                cmd.ExecuteNonQuery();
                cmd2.CommandText="Insert into user_loginlogin values('"+slectid.Text+"','"+slectid.Text+"')";
                cmd2.ExecuteNonQuery();
             }
            catch (SqlException)
            {
                cmd.CommandText = "Update lecturer_det set lecturer_id='" + slectid.Text + "',l_name='" + textlname.Text + "' where lecturer_id='" + slectid.Text + "'";
                cmd.ExecuteNonQuery();
                cmd2.CommandText = "Insert into user_login values('" + slectid.Text + "','" + slectid.Text + "')";
                cmd2.ExecuteNonQuery();
            }
        }

        private void slectid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listlectsubj.Items.Clear();
                cmd = new SqlCommand("select * from lecturer_det where lecturer_id='" + slectid.Text + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                dr.Read();
                textlname.Text = dr["l_name"].ToString();
                s = dr["subjects"].ToString();
                dr.Close();
                int i = 0;
                string sn = "";
                while (i <= s.Length)
                {
                    if (i < s.Length & s[i] != ' ')
                    {
                        sn = sn + s[i];
                    }
                    else
                    {
                        cmd = new SqlCommand("select subj_name from subj_details where subj_code='" + sn + "'", mainapms.con);
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        sn = dr["subj_name"].ToString();
                        dr.Close();
                        listlectsubj.Items.Add(sn);
                        sn = "";
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                dr.Close();
            }
        }

        private void bttnaddsubj_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select subj_code from subj_details where subj_name='" + ssubj.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            int i=0;
            bool exists=false ;
            while (i<listlectsubj.Items.Count)
            {
                if(listlectsubj.Items[i].ToString()==ssubj.Text)
                exists = true;
                i++;
            }
            if (!exists)
            {
                try
                {
                    string sc = dr["subj_code"].ToString();             
                
                dr.Close();
                s += sc;
                cmd.CommandText = "Update lecturer_det set subjects='" + s + "' where lecturer_id='" + slectid.Text + "'";
                cmd.ExecuteNonQuery();
                listlectsubj.Items.Add(ssubj.Text);
                }
                catch (Exception)
                { }
            
            }
        }

        private void bttnremsubj_Click(object sender, EventArgs e)
        {
            listlectsubj.Items.RemoveAt(listlectsubj.SelectedIndex);
            int i=0;
            s="";
            while (i < listlectsubj.Items.Count)
            {
                cmd = new SqlCommand("select subj_code from subj_details where subj_name='" + listlectsubj.Items[i].ToString() + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                dr.Read();
                string sc = dr["subj_code"].ToString();
                dr.Close();
                s += sc;
            }
        }

        private void bttnclearsubj_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want clear the subject responsibilty data of lecturer?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d.Equals(DialogResult.Yes))
            {
                listlectsubj.Items.Clear();
                cmd = new SqlCommand("select * from lecturer_det", mainapms.con);
                cmd.CommandText = "Update lecturer_det set subjects= NULL where lecturer_id='" + slectid.Text + "'";
                cmd.ExecuteNonQuery();
            }

        }

        private void bttndellect_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure you want to delete the displayed lecturer data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d.Equals(DialogResult.Yes))
            {
                cmd = new SqlCommand("select * from lecturer_det", mainapms.con);
                cmd.CommandText = "delete from lecturer_det where lecturer_id='" + slectid.Text + "'";
                cmd.ExecuteNonQuery();
            }
        }
       }
}