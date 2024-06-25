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
    public partial class attdretstud : Form
    {        
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dtpr,dtab;
        public attdretstud()
        {
            InitializeComponent();        
        }

            private void textrno_Leave(object sender, EventArgs e)
        {
            sclass.Items.Clear();
            cmd = new SqlCommand("select distinct class from stud_cl_det where roll_no='"+textrno.Text+"'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sclass.Items.Add(dr["class"].ToString());
            }
            dr.Close();
        }

        private void bttnattddet_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select subj_code from subj_details where subj_name='" + ssubj.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string sc = dr["subj_code"].ToString();
            dr.Close();
            dtpr=new DataTable();
            dtab = new DataTable();
            da = new SqlDataAdapter("select stud_atte_dat.lsno,dt_of_ls from stud_atte_dat,lect_sess_tim where attendance='true'" + " and stud_atte_dat.subj_code='" + sc + "' and roll_no='" + textrno.Text + "' and batch =(select batch from stud_details where roll_no='" + textrno.Text + "') and stud_atte_dat.subj_code=lect_sess_tim.subj_code and stud_atte_dat.lsno=lect_sess_tim.lsno ", mainapms.con);
            da.Fill(dtpr);
            dataGridViewpres.DataSource = dtpr;
            da = new SqlDataAdapter("select stud_atte_dat.lsno,dt_of_ls from stud_atte_dat,lect_sess_tim where attendance='false'" + " and stud_atte_dat.subj_code='" + sc + "' and roll_no='" + textrno.Text + "' and batch =(select batch from stud_details where roll_no='" + textrno.Text + "') and stud_atte_dat.subj_code=lect_sess_tim.subj_code and stud_atte_dat.lsno=lect_sess_tim.lsno", mainapms.con);
            da.Fill(dtab);
            dataGridViewabs.DataSource = dtab;
            calcpercattd a = new calcpercattd(textrno.Text, sc);
            float perc = a.calc();
            labelperc.Text = "Percentage " + perc+ " %";
        }

        private void sclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ssubj.Items.Clear();
                cmd = new SqlCommand("select subj_name,subj_code,subj_type from subj_details where class_of_subj=" + int.Parse(sclass.Text) + " and syllabus=(select syllabus from stud_details where roll_no='"+textrno.Text +"') and course=(select course from stud_details where roll_no='"+textrno.Text+"')", mainapms.con);
                dr = cmd.ExecuteReader();
                SqlConnection con2 = new SqlConnection();
                con2.ConnectionString = @" Data Source=.\SQLEXPRESS;AttachDbFilename= D:\APMS\coursedat.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True";
                con2.Open();
                while (dr.Read())
                {
                    if (dr["subj_type"].ToString() == "General")
                        ssubj.Items.Add(dr["subj_name"].ToString());
                    else if (dr["subj_type"].ToString() == "Opt Language" | dr["subj_type"].ToString() == "Opt Subject")
                    {
                        string op;
                        if (dr["subj_type"].ToString() == "Opt Language")
                            op = "opt_lang";
                        else
                            op = "opt_subj";

                        SqlCommand cmd2 = new SqlCommand("select " + op + " from stud_cl_det where class=" + int.Parse(sclass.Text) + " and roll_no='" + textrno.Text + "'", con2);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        dr2.Read();
                        if (dr["subj_code"].ToString() == dr2[op].ToString())
                            ssubj.Items.Add(dr["subj_name"].ToString());
                        dr2.Close();
                    }
                }
                dr.Close();
                con2.Close();

                cmd = new SqlCommand("select subj_name from subj_details where class_of_subj=" + int.Parse(sclass.Text) + " and course=(select course from stud_details where roll_no='" + textrno.Text + "') and subj_code=(select opt_subj from stud_cl_det where roll_no='" + textrno.Text + "')", mainapms.con);
                dr = cmd.ExecuteReader();
                dr.Read();
                ssubj.Items.Add(dr["subj_name"].ToString());
                dr.Close();
                cmd = new SqlCommand("select subj_name from subj_details where class_of_subj=" + int.Parse(sclass.Text) + " and course=(select course from stud_details where roll_no='" + textrno.Text + "') and subj_code=(select opt_lang from stud_cl_det where roll_no='" + textrno.Text + "')", mainapms.con);
                dr = cmd.ExecuteReader();
                dr.Read();
                ssubj.Items.Add(dr["subj_name"].ToString());
                dr.Close();
            }
            catch (Exception)
            {
                dr.Close();
            }
        }

        private void textrno_TextChanged(object sender, EventArgs e)
        {
            labelstname.Text = "";
            cmd = new SqlCommand("select s_name from stud_details where roll_no='" + textrno.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
                labelstname.Text = dr["s_name"].ToString();
            dr.Close();
        }
    }
}
