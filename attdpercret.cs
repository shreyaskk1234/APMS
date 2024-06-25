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
    public partial class attdpercret : Form
    {        
        SqlCommand cmd;
        SqlDataReader dr;
        string sc, st;
        public attdpercret()
        {
            InitializeComponent();
        }

        private void attdpercret_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select distinct course from subj_details", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                scourse.Items.Add(dr["course"].ToString());
            }
            dr.Close();
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
        }

        private void sclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            ssubj.Items.Clear();
            cmd = new SqlCommand("select distinct subj_name from subj_details where class_of_subj=" + int.Parse(sclass.Text) + " and syllabus='" + ssyllabus.Text + "' and course='" + scourse.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ssubj.Items.Add(dr["subj_name"].ToString());
            }
            dr.Close();
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
            cmd = new SqlCommand("select subj_code,subj_type from subj_details where subj_name='" + ssubj.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            sc = dr["subj_code"].ToString();
            st = dr["subj_type"].ToString();
            dr.Close();
        }
        private void bttnpercattd_Click(object sender, EventArgs e)
        {
            textd.Text= "Roll no\t\tName\t\tAttendance %\r\n";
            float perc;
            calcpercattd a=new calcpercattd();
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = @" Data Source=.\SQLEXPRESS;AttachDbFilename= D:\APMS\coursedat.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True";
            con2.Open();            
            cmd = new SqlCommand("select roll_no,s_name from stud_details where course='" + scourse.Text + "' and batch='" + sbatch.Text + "'", con2);
            dr = cmd.ExecuteReader();    
            bool valid=false;
            while (dr.Read())   
            {
                if (st == "Opt Subject" | st == "Opt Language")
                {
                    SqlConnection tempcon = new SqlConnection();
            tempcon.ConnectionString = @" Data Source=.\SQLEXPRESS;AttachDbFilename= D:\APMS\coursedat.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True";
            tempcon.Open();
            SqlCommand tcmd=new SqlCommand("select * from stud_cl_det",tempcon);
            SqlDataReader tdr;
            if (st == "Opt Subject")               
                tcmd = new SqlCommand("select roll_no from stud_cl_det where class='" + sclass.Text + "' and opt_subj='" + sc + "'", tempcon);
            else if(st=="Opt Language")
            tcmd = new SqlCommand("select roll_no from stud_cl_det where class='" + sclass.Text + "' and opt_lang='" + sc+ "'", tempcon);
                    tdr = tcmd.ExecuteReader();
                    while (tdr.Read())
                    {
                        if (tdr["roll_no"].ToString() == dr["roll_no"].ToString())
                            valid = true;
                    }
                }
                else if (st == "General")
                    valid = true;
                if (valid)
                {
                    a.setargs(dr["roll_no"].ToString(), sc);
                    perc = a.calc();
                    if (optallstud.Checked)
                        textd.Text += dr["roll_no"].ToString() + "\t\t" + dr["s_name"].ToString() + "\t\t" + perc + "\r\n";
                    else if (optlethan.Checked)
                    {
                        if (perc < float.Parse(textperc.Text))
                            textd.Text += dr["roll_no"].ToString() + "\t\t" + dr["s_name"].ToString() + "\t\t" + perc + "\r\n";
                    }
                    valid = false;
                }

            }
            dr.Close();
            con2.Close();
        }

        private void optallstud_CheckedChanged(object sender, EventArgs e)
        {
            if (optallstud.Checked)
                textperc.Enabled = false;
            else
                textperc.Enabled = true;
        }
     }

}