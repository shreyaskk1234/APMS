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
    public partial class attdrec : Form
    {        
        SqlCommand cmd;
        SqlDataReader dr;
        public attdrec()
        {
            InitializeComponent();
        }

        private void attdrec_Load(object sender, EventArgs e)
        {//Code extracts all the distinct values of course from table of subject details
            cmd = new SqlCommand("select distinct course from subj_details", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                scourse.Items.Add(dr["course"].ToString());
            }
            dr.Close();
        }

        private void bttnrec_Click(object sender, EventArgs e)
        {                  
            string r = textrollno.Text;
            int i = 0;
            int j = -1;
            string rn = "";
            cmd = new SqlCommand("select subj_code,subj_type from subj_details where subj_name='" + ssubj.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string sc= dr["subj_code"].ToString();
            string st = dr["subj_type"].ToString();
            dr.Close();
            if (st == "General")
            {
                cmd = new SqlCommand("select count(*) as c from stud_details where course='" + scourse.Text + "' and batch='" + sbatch.Text + "'", mainapms.con);
            }
            else if (st == "Opt Language")
            {
                cmd = new SqlCommand("select count(*) as c from stud_details, stud_cl_det where course='" + scourse.Text + "' and batch='" + sbatch.Text + "' and opt_lang='" + sc + "' and stud_details.roll_no=stud_cl_det.roll_no", mainapms.con);
            }
            else if (st == "Opt Subject")
            {
                cmd = new SqlCommand("select count(*) as c from stud_details,stud_cl_det where course='" + scourse.Text + "' and batch='" + sbatch.Text + "' and opt_subj='" + sc + "' and stud_details.roll_no=stud_cl_det.roll_no", mainapms.con);
            }
            dr = cmd.ExecuteReader();
            dr.Read();
            int c = int.Parse(dr["c"].ToString());
            dr.Close();
            string[] ra = new string[c];
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = @" Data Source=.\SQLEXPRESS;AttachDbFilename= D:\APMS\coursedat.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True";
            con2.Open();
            SqlCommand cmd2;            
            cmd = new SqlCommand("select * from stud_atte_dat", mainapms.con);
            while (i <= r.Length)
            {
                if ( i<r.Length && r[i] != '\r' && r[i] != ' ' && r[i]!='\t')
                {
                    if (r[i] != '\n')
                    rn = rn + r[i];
                }
                else
                {
                    string op="";
                    bool valid=false;
                    cmd = new SqlCommand("select * from stud_details where roll_no='" + rn + "' and course ='" + scourse.Text + "' and batch ='" + sbatch.Text + "'", mainapms.con);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())                    
                        valid = true;                        
                    else
                        valid = false;
                        dr.Close();
                    
                    if (valid)
                    {
                        SqlDataReader dr2;
                        if (st == "General")
                            valid = true;
                        if (st == "Opt language")
                        {
                            cmd2 = new SqlCommand("select opt_lang from stud_cl_det where roll_no='" + rn + "' and class=(select class_of_subj from subj_details where subj_code='" + sc + "')", mainapms.con);
                            dr2 = cmd.ExecuteReader();
                            dr2.Read();
                                op = dr2["opt_lang"].ToString();
                            if (op == sc)
                                valid = true;
                            dr2.Close();
                        }
                        else if (st == "Opt subject")
                        {
                            cmd2 = new SqlCommand("select opt_subj from stud_cl_det where roll_no='" + rn + "' and class=(select class_of_subj from subj_details where subj_code='" + sc + "')", mainapms.con);
                            dr2 = cmd.ExecuteReader();
                            dr.Read();
                                op = dr2["opt_subj"].ToString();
                            if (op == sc)
                                valid = true;
                            dr2.Close();
                        }
                    }
                    if (valid)
                    {
                        try
                        {
                            if (opteditm.Checked)
                                cmd.CommandText = "Update stud_atte_dat set attendance='" + optmarkpres.Checked + "' where subj_code='" + sc + "' and roll_no='" + rn + "' and lsno=" + int.Parse(textssno.Text);
                            else
                                cmd.CommandText = "Insert into stud_atte_dat values('" + sc + "','" + rn + "'," + int.Parse(textssno.Text) + ",'" + optmarkpres.Checked + "')";

                            cmd.ExecuteNonQuery();
                            rn = "";
                        }
                        catch (Exception)
                        {
                            //  MessageBox.Show(ex.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }                
                i++;
            }
            if (optmarkopps.Checked)
            {
                if (st == "General")
                cmd = new SqlCommand("select stud_details.roll_no from stud_details where course='" + scourse.Text + "' and batch='" + sbatch.Text + "'", mainapms.con);
                else if (st == "Opt Language")
                    cmd = new SqlCommand("select stud_details.roll_no from stud_details,stud_cl_det where course='" + scourse.Text + "' and batch='" + sbatch.Text + "' and opt_lang='" + sc + "' and stud_details.roll_no=stud_cl_det.roll_no", mainapms.con);
                else if (st == "Opt Subject")
                cmd = new SqlCommand("select stud_details.roll_no from stud_details,stud_cl_det where course='" + scourse.Text + "' and batch='" + sbatch.Text + "' and opt_subj='"+sc+"' and stud_details.roll_no=stud_cl_det.roll_no", mainapms.con);
                dr = cmd.ExecuteReader();               
                cmd2 = new SqlCommand("select * from stud_atte_dat", con2);
                bool exists;
                while (dr.Read())
                {
                    exists = false;
                    for (i = 0; i <= j; i++)
                    {
                        if (dr["roll_no"].ToString().Equals(ra[i]))
                        {
                            exists = true;
                            break;
                        }
                    }
                    if (!exists)
                    {
                        if (opteditm.Checked)
                            cmd2.CommandText = "Update stud_atte_dat set attendance='" + (!(optmarkpres.Checked)) + "' where subj_code='" + sc + "' and roll_no='" + dr["roll_no"].ToString() + "' and lsno=" + int.Parse(textssno.Text);
                        else
                        cmd2.CommandText = "Insert into stud_atte_dat values('" + sc + "','" + dr["roll_no"].ToString() + "'," + int.Parse(textssno.Text) + ",'" + (!(optmarkpres.Checked)) + "')";
                        try
                        {
                            cmd2.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                           // MessageBox.Show(ex.Message);
                        }
                    }
                }
                
                con2.Close();
                dr.Close();
            }           
            cmd = new SqlCommand("select * from lect_sess_tim", mainapms.con);           
            if(opteditm.Checked)
            cmd.CommandText = "Update lect_sess_tim set dt_of_ls='"+ datesess.Value.Date+"' where subj_code='" + sc + "' and batch='" + sbatch.Text + "' and lsno=" + int.Parse(textssno.Text);
            else
            cmd.CommandText = "Insert into lect_sess_tim(subj_code,batch,lsno,dt_of_ls) values('" + sc + "','" + sbatch.Text + "'," + int.Parse(textssno.Text) + ",'" + datesess.Value.Date + "')";
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {}
            if (optconstime.Checked)
            {
                cmd.CommandText = "Update lect_sess_tim set time_ls='" + Convert.ToDateTime(timesess.Value.ToShortTimeString()) + "' where subj_code='" + sc + "' and batch='" + sbatch.Text + "' and lsno=" + int.Parse(textssno.Text);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Data Recorded");
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

        }

        private void textssno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' & e.KeyChar <= '9' | e.KeyChar==8)
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void bttnres_Click(object sender, EventArgs e)
        {
            try{
            scourse.SelectedIndex = -1;
            ssyllabus.SelectedIndex = -1;
            sclass.SelectedIndex = -1;
            ssubj.SelectedIndex = -1;
            sbatch.SelectedIndex = -1;
            textssno.Text = "";
            textssno.Text = "";
            optconstime.Checked = false;
            optmarkopps.Checked = false;
            optmarkopps.Checked = true;
            opteditm.Checked = false;
    }
    catch(Exception)
{}
        }  
    }
}
