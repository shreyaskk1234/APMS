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
    public partial class subjdetsear : Form
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader dr;
        public subjdetsear()
        {
            InitializeComponent();
        }

        private void subjdetsear_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select distinct course from subj_details", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                scourse.Items.Add(dr["course"].ToString());
            }
            dr.Close();
            if (mainapms.cusert == "Student")
            {
                bttndelsubjdet.Enabled = false;
                bttneditsubjdet.Enabled = false;
            }
        }
          private void scourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            ssyllabus.Items.Clear();
            cmd = new SqlCommand("select distinct syllabus from subj_details where course='" + scourse.Text + "'", mainapms.con);
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
            cmd = new SqlCommand("select distinct class_of_subj from subj_details where syllabus='" + ssyllabus.Text + "' and course='" + scourse.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sclass.Items.Add(dr["class_of_subj"].ToString());
            }
            dr.Close();
            cmd = new SqlCommand("select distinct class_of_subj from proj_details where syllabus='" + ssyllabus.Text + "' and course='" + scourse.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sclass.Items.Add(dr["class_of_subj"].ToString());
            }
            dr.Close();

        }      
        private void bttndispsubjdet_Click(object sender, EventArgs e)
        {
            dt=new DataTable();
            if(ssubjtype.Text!="Project Work")
            da=new SqlDataAdapter("select * from subj_details where subj_name like '"+textsubjcr.Text+"' and class_of_subj="+sclass.Text+" and syllabus='"+ssyllabus.Text+"' and course='"+scourse.Text+"' and subj_type='"+ssubjtype.Text+"'",mainapms.con);
            else
                da = new SqlDataAdapter("select * from proj_details where subj_name like '" + textsubjcr.Text + "' and class_of_subj=" + sclass.Text + " and syllabus='" + ssyllabus.Text + "' and course='" + scourse.Text + "'", mainapms.con);

            da.Fill(dt);
            dataGridView1.DataSource = dt;               
        }

        private void bttneditsubjdet_Click(object sender, EventArgs e)
        {
            string sc=dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string cs=dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            subjdetrec sd = new subjdetrec(sc, cs);
            sd.Show();
        }

        private void bttndelsubjdet_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Are you sure you want to delete all data of selected subject?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("select * from stud_atte_dat", mainapms.con);
                    cmd.CommandText = "Delete from stud_atte_dat where subj_code='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
                try
                {
                    cmd = new SqlCommand("select * from stud_scor", mainapms.con);
                    cmd.CommandText = "Delete from stud_scor where subj_code='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
                try
                {
                    cmd = new SqlCommand("select * from stubg_scor", mainapms.con);
                    cmd.CommandText = "Delete from stubg_scor where subj_code='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {}
                try
                {
                    cmd = new SqlCommand("select * from stud_proj_scor", mainapms.con);
                    cmd.CommandText = "Delete from stud_proj_scor where subj_code='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
                try
                {
                    cmd = new SqlCommand("select * from lect_sess_time", mainapms.con);
                    cmd.CommandText = "Delete from lect_sess_tim where subj_code='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
                try
                {
                    cmd = new SqlCommand("select * from subj_details", mainapms.con);
                    cmd.CommandText = "Delete from subj_details where subj_code='" + dataGridView1.SelectedRows[0].Cells[0].Value + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }

            }
        }
    }
}
 