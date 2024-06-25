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
    public partial class attdretsess : Form
    {
        
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;
        string sc;
        public attdretsess()
        {
            InitializeComponent();
        }            

        private void attdretsess_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select distinct course from subj_details", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                scourse.Items.Add(dr["course"].ToString());
            }
            dr.Close();
            if (mainapms.cusert == "Student")
                bttndeldatsess.Enabled=false;
        }
        private void scourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ssyllabus.Items.Clear();
            cmd = new SqlCommand("select distinct syllabus from subj_details where course='"+scourse.Text+"'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ssyllabus.Items.Add(dr["syllabus"].ToString());
            }
            dr.Close();
 
        }

        private void ssyllabus_SelectedIndexChanged(object sender, EventArgs e)
        {
            sclass.Items.Clear();
            cmd = new SqlCommand("select distinct class_of_subj from subj_details where syllabus='"+ssyllabus.Text+"' and course='"+scourse.Text+"'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sclass.Items.Add(dr["class_of_subj"].ToString());
            }
            dr.Close();
 
        }

        private void sclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ssubj.Items.Clear();
            cmd = new SqlCommand("select distinct subj_name from subj_details where class_of_subj="+int.Parse(sclass.Text)+" and syllabus='"+ssyllabus.Text+"' and course='"+scourse.Text+"'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ssubj.Items.Add(dr["subj_name"].ToString());
            }
            dr.Close();
         }

        
        private void textssno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' & e.KeyChar <= '9' | e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void ssubj_SelectedIndexChanged(object sender, EventArgs e)
        {
            sbatch.Items.Clear();
            cmd = new SqlCommand("select distinct batch from stud_details ", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sbatch.Items.Add(dr["batch"].ToString());
            }
            dr.Close();
            cmd = new SqlCommand("select subj_code from subj_details where subj_name='" + ssubj.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            sc = dr["subj_code"].ToString();
            dr.Close();
        }
        
        private void bttndispstudr_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            try
            {
                if (optconsdate.Checked)
                    da = new SqlDataAdapter("select stud_atte_dat.roll_no,s_name from stud_atte_dat,stud_details where attendance='" + optpresstud.Checked + "' and lsno=(select lect_sess_tim.lsno from lect_sess_tim where dt_of_ls='" + datesess.Value.Date + "') and subj_code='" + sc + "' and stud_atte_dat.roll_no=stud_details.roll_no and batch='" + sbatch.Text + "'", mainapms.con);
                else
                    da = new SqlDataAdapter("select stud_atte_dat.roll_no,s_name from stud_atte_dat,stud_details where attendance='" + optpresstud.Checked + "' and lsno=" + int.Parse(textssno.Text) + " and subj_code='" + sc + "' and stud_atte_dat.roll_no=stud_details.roll_no and batch='" + sbatch.Text + "'", mainapms.con);
                da.Fill(dt);
                dataGridView.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
       }

        private void bttndeldatsess_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = @" Data Source=.\SQLEXPRESS;AttachDbFilename= D:\APMS\coursedat.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True";
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select * from stud_details",con2);
            cmd2.CommandText = "select roll_no from stud_details where batch='" + sbatch.Text + "'";
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                cmd = new SqlCommand("select * from stud_atte_dat", mainapms.con);
                cmd.CommandText = "delete from stud_atte_dat where lsno=" + int.Parse(textssno.Text) + " and subj_code='" + sc + "' and roll_no='" + dr2["roll_no"].ToString() + "'";
                cmd.ExecuteNonQuery();
            }
            dr2.Close();
            cmd.CommandText="delete from lect_sess_tim where batch='"+sbatch.Text+"' and lsno=" + int.Parse(textssno.Text) + " and subj_code='" + sc + "'";
            cmd.ExecuteNonQuery();

        }
       
    }
}
