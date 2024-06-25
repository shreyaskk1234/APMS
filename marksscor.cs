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
    public partial class marksscor : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        string sc, mt, ct, st;
        bool rexists,hlia;
        int ia;
        public marksscor()
        {
            InitializeComponent();
        }

        private void marksscrec_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select distinct course from subj_details", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                scourse.Items.Add(dr["course"].ToString());
            }
            dr.Close();
            if (mainapms.cusert == "Student")
                bttnsave.Enabled = false;
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

        private void smarkstype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dr.IsClosed)
                dr.Close();
            if (st != "Project Work")
            {
                if (smarkstype.Text == "Main marks")
                    mt = "maxmarks";
                     else if (smarkstype.Text == "IA Aggregate")
                    mt = "maxia";
                else
                    mt = "maxiaexam";
                
                cmd = new SqlCommand("select " + mt + " from subj_details where subj_code='" + sc + "' and course='" + scourse.Text + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                dr.Read();
            }
            else
            {
                if (smarkstype.Text == "Dissertation")
                    mt = "maxdissertmarks";
                else if (smarkstype.Text == "IA Aggregate")
                    mt = "maxia";
                else if (smarkstype.Text == "Viva Voce")
                    mt = "maxvivamarks";
                else
                {
                    mt="maxia";
                    hlia = true;
                }              
                cmd = new SqlCommand("select " + mt + " from proj_details where subj_code='" + sc + "' and course='" + scourse.Text + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                dr.Read();
            }
            if (!hlia)
                lsmaxmk.Text = dr[mt].ToString();
            else
            {
                lsmaxmk.Text = (int.Parse(dr[mt].ToString()) / 2).ToString();
                hlia = false;
            }
            dr.Close();

            if (smarkstype.Text == "Main marks")
                ct = "marks";
            else if (smarkstype.Text == "Dissertation")                         
                ct = "dissert";
            else if (smarkstype.Text == "IA Aggregate")
                ct = "IA";
            else if (smarkstype.Text == "Viva Voce")
                ct = "viva";
            else if (smarkstype.Text == "First IA")
                ct = "IA_1m";
            else
                ct = "IA_2m";

            if (st != "Project Work")
            cmd = new SqlCommand("select " + ct + " from stud_scor where roll_no='" + textrno.Text + "' and subj_code='" + sc + "'", mainapms.con);
            else
            cmd = new SqlCommand("select " + ct + " from stud_proj_scor where roll_no='" + textrno.Text + "' and subj_code='" + sc + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();            
            rexists = dr.HasRows;
            if (rexists)
            {
                textsmarks.Text = dr[ct].ToString();
            }
            dr.Close();
            if (smarkstype.Text.Equals("Main marks") || smarkstype.Text.Equals("Dissertation") || smarkstype.Text.Equals("Viva Voce"))
            {
                optbgscor.Enabled = true;                
                sattno.Items.Clear();
                cmd = new SqlCommand("select attempt_no from stubg_scor where roll_no='" + textrno.Text + "' and backlog='" + sc + "'", mainapms.con);
                dr = cmd.ExecuteReader();   
                while (dr.Read())
                    {
                        if (dr.HasRows)                
                        sattno.Items.Add(dr["attempt_no"].ToString());
                    }                
                dr.Close();
            }
            else
            {
                optbgscor.Checked = false;
                optbgscor.Enabled = false;
                sattno.Text = "";
                sattno.Items.Clear();
            }
        }

        private void bttnsave_Click(object sender, EventArgs e)
        {
            if (int.Parse(textsmarks.Text) > int.Parse(lsmaxmk.Text))//Validation of marks score
            {
                MessageBox.Show("Invalid marks.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (!rexists)//If there is no record in the database of the specified student subject the code inserts the record without marks score
            {
                if(st!="Project Work")
                cmd.CommandText = "Insert into stud_scor(roll_no,subj_code) values('" + textrno.Text + "','" + sc + "')";
                else
                cmd.CommandText = "Insert into stud_proj_scor(roll_no,subj_code) values('" + textrno.Text + "','" + sc + "')";
                cmd.ExecuteNonQuery();
            }
            if (!optbgscor.Checked)//The code stores the marks score
            {
                if (st != "Project Work")
                {
                    cmd = new SqlCommand("select * from stud_scor", mainapms.con);
                    cmd.CommandText = "Update stud_scor set " + ct + "=" + int.Parse(textsmarks.Text) + " where roll_no='" + textrno.Text + "' and subj_code='" + sc + "'";
                }
                else
                {
                    cmd = new SqlCommand("select * from stud_proj_scor", mainapms.con);
                    cmd.CommandText = "Update stud_proj_scor set " + ct + "=" + int.Parse(textsmarks.Text) + " where roll_no='" + textrno.Text + "' and subj_code='" + sc + "'";
                }            
            }
            else
            {
                cmd = new SqlCommand("select * from stubg_scor", mainapms.con);
                cmd.CommandText = "Update stubg_scor set " + ct + "=" + int.Parse(textsmarks.Text) + " where roll_no='" + textrno.Text + "' and backlog='" + sc + "' and attempt_no="+int.Parse(sattno.Text);
            }
            cmd.ExecuteNonQuery();
            if(st!="Project Work")
            {
            cmd = new SqlCommand("select IA_1m,IA_2m from stud_scor where roll_no='" + textrno.Text + "' and subj_code='" + sc + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if ((!dr.IsDBNull(0)) && (!dr.IsDBNull(1)))
            {
                int ia1m = int.Parse(dr["IA_1m"].ToString());
                int ia2m = int.Parse(dr["IA_2m"].ToString());
                dr.Close();                
                cmd = new SqlCommand("select maxia,maxiaexam from subj_details where subj_code='" + sc + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                dr.Read();
                int maxia = int.Parse(dr["maxia"].ToString());
                int maxiaexam = int.Parse(dr["maxiaexam"].ToString());
                dr.Close();                
                    ia = (int)(((float)(ia1m + ia2m)) / (2 * maxiaexam) * maxia);
                    cmd.CommandText = "Update stud_scor set IA=" + ia + " where roll_no='" + textrno.Text + "' and subj_code='" + sc + "'";
                    cmd.ExecuteNonQuery();
            }                                
            }
            if (!dr.IsClosed)
                dr.Close();
            int dtia=0,m=0,v=0;
            bool iaex,mkex;
            if (!optbgscor.Checked)
            {
                if (st != "Project Work")
                cmd = new SqlCommand("select IA,marks from stud_scor where roll_no='" + textrno.Text + "' and subj_code='" + sc + "'", mainapms.con);
                else
                cmd = new SqlCommand("select dissert,viva from stud_proj_scor where roll_no='" + textrno.Text + "' and subj_code='" + sc + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (st != "Project Work")
                {
                    iaex = !dr.IsDBNull(0);
                    mkex = !dr.IsDBNull(1);
                    if(iaex)
                    dtia = int.Parse(dr["IA"].ToString());
                    if(mkex)
                    m = int.Parse(dr["marks"].ToString());                   
                }
                else
                {
                    iaex = !dr.IsDBNull(0);
                    mkex = !dr.IsDBNull(1);
                    if(iaex)
                    m = int.Parse(dr["dissert"].ToString());
                    if(mkex)
                    v = int.Parse(dr["viva"].ToString());                    
                    dr.Close();
                }
            }
            else
            {
                if (st != "Project Work")
                {
                    cmd = new SqlCommand("select IA from stud_scor where roll_no='" + textrno.Text + "' and subj_code='" + sc + "'", mainapms.con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    iaex = !dr.IsDBNull(0);
                    dtia = int.Parse(dr["IA"].ToString());
                    dr.Close();
                    cmd = new SqlCommand("select marks from stubg_scor where roll_no='" + textrno.Text + "' and backlog='" + sc + "' and attempt_no=" + int.Parse(sattno.Text), mainapms.con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    mkex = !dr.IsDBNull(0);
                    if (mkex)
                        m = int.Parse(dr["marks"].ToString());
                    dr.Close();
                }
                else
                {
                    cmd = new SqlCommand("select marks,viva from stubg_scor where roll_no='" + textrno.Text + "' and backlog='" + sc + "'", mainapms.con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    iaex = !dr.IsDBNull(0);
                    mkex = !dr.IsDBNull(1);
                    if (iaex)
                        m = int.Parse(dr["marks"].ToString());
                    if (mkex)
                        v = int.Parse(dr["viva"].ToString());
                    dr.Close();
                }

            }
            if (iaex && mkex)
            {
                if (!dr.IsClosed)
                    dr.Close();
                if(!optbgscor.Checked)
                cmd = new SqlCommand("select * from stubg_scor where roll_no='" + textrno.Text + "' and backlog='" + sc + "' and attempt_no=2", mainapms.con);
                else                    
                cmd = new SqlCommand("select * from stubg_scor where roll_no='" + textrno.Text + "' and backlog='" + sc + "' and attempt_no="+(int.Parse(sattno.Text)+1), mainapms.con);                
                dr = cmd.ExecuteReader();
                dr.Read();
                rexists = dr.HasRows;
                dr.Close();
                if (st != "Project Work")
                cmd = new SqlCommand("select minpassperc,maxmarks,maxia from subj_details where subj_code='" + sc + "' and course='"+scourse.Text+"'", mainapms.con);
                else
                cmd = new SqlCommand("select minpassperc,maxdissertmarks,maxvivamarks from proj_details where subj_code='" + sc + "' and course='" + scourse.Text + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                dr.Read();
                float minp = float.Parse(dr["minpassperc"].ToString());
                int max1, max2;
                if (st != "Project Work")
                {
                    max1 = int.Parse(dr["maxmarks"].ToString());
                    max2 = int.Parse(dr["maxia"].ToString());
                }
                else
                {
                    max1 = int.Parse(dr["maxdissertmarks"].ToString());
                    max2 = int.Parse(dr["maxvivamarks"].ToString());
                }
                dr.Close();
                bool isbk;
                if (st != "Project Work")
                isbk = (((float)m < (minp / 100) * max1) | (((float)(m + dtia)) < (minp / 100) * (max1 + max2)));
                else
                    isbk = (((float)m < (minp / 100) * max1) | ((float)v < (minp / 100) * max2));
                if (isbk)
                {
                    if (!rexists)
                    {                        
                        if(!optbgscor.Checked)
                        cmd.CommandText = "Insert into stubg_scor(roll_no,backlog,attempt_no) values('" + textrno.Text + "','" + sc + "',2)";
                        else
                        cmd.CommandText = "Insert into stubg_scor(roll_no,backlog,attempt_no) values('" + textrno.Text + "','" + sc + "',"+(int.Parse(sattno.Text)+1)+")";
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {                    
                    if (rexists)
                    {                        
                        if(!optbgscor.Checked)
                        cmd.CommandText = "Delete from stubg_scor where roll_no='" + textrno.Text + "' and backlog='" + sc + "'";
                        else
                        cmd.CommandText = "Delete from stubg_scor where roll_no='" + textrno.Text + "' and backlog='" + sc + "' and attempt_no>"+int.Parse(sattno.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
         }

        private void satno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select " + ct + " from stubg_scor where roll_no='" + textrno.Text + "' and backlog='" + sc + "' and attempt_no="+int.Parse(sattno.Text), mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            rexists = dr.HasRows;
            if (rexists)
            {
                textsmarks.Text = dr[ct].ToString();
            }
            dr.Close();
        }
        private void ssubj_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select subj_code,subj_type from subj_details where subj_name='" + ssubj.Text + "' and course='" + scourse.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                sc = "";
                sc = dr["subj_code"].ToString();
                st = dr["subj_type"].ToString();
                dr.Close();
                if (st == "EC/CC")
                {
                    smarkstype.Items.Remove("First IA");
                    smarkstype.Items.Remove("Second IA");
                    smarkstype.Items.Remove("Main marks");
                }
                else
                {
                    if(!smarkstype.Items.Contains("First IA"))
                    smarkstype.Items.Insert(0, "First IA");
                    if (!smarkstype.Items.Contains("Second IA"))
                    smarkstype.Items.Insert(1, "Second IA");
                    if (!smarkstype.Items.Contains("Main marks"))
                    smarkstype.Items.Insert(3, "Main marks");
                }
            }
            else
            {
                if (!dr.IsClosed)
                    dr.Close();
                cmd = new SqlCommand("select subj_code from proj_details where subj_name='" + ssubj.Text + "' and course='" + scourse.Text + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    sc = dr["subj_code"].ToString();
                    st = "Project Work";
                    dr.Close();
                    smarkstype.Items.Remove("Main marks");
                    smarkstype.Items.Remove("IA Aggregate");
                    if(!smarkstype.Items.Contains("Dissertation"))
                    smarkstype.Items.Add("Dissertation");
                    if (!smarkstype.Items.Contains("Viva Voce"))
                    smarkstype.Items.Add("Viva Voce");
                }
            }

        }

        private void textrno_TextChanged(object sender, EventArgs e)
        {
            labelstname.Text = "";
            cmd = new SqlCommand("select s_name from stud_details where roll_no='" + textrno.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if(dr.HasRows)
            labelstname.Text = dr["s_name"].ToString();
            dr.Close();            
        }

        private void textsmarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' & e.KeyChar <= '9' | e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        } 

        private void textrno_Leave(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = @" Data Source=.\SQLEXPRESS;AttachDbFilename= D:\APMS\coursedat.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True";
            con2.Open();
            ssubj.Items.Clear();
            cmd = new SqlCommand("select subj_name,subj_code,subj_type from subj_details where class_of_subj=" + int.Parse(sclass.Text) + " and syllabus='" + ssyllabus.Text + "' and course='" + scourse.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr["subj_type"].ToString() == "General" | dr["subj_type"].ToString() == "EC/CC")
                    ssubj.Items.Add(dr["subj_name"].ToString());
                else if (dr["subj_type"].ToString() == "Opt Language" | dr["subj_type"].ToString() == "Opt Subject")
                {
                    string op;
                    if (dr["subj_type"].ToString() == "Opt Language")
                        op = "opt_lang";
                    else
                        op = "opt_subj";
                    SqlCommand cmd2 = new SqlCommand("select " + op + " from stud_cl_det where class=" + int.Parse(sclass.Text)+" and roll_no='"+textrno.Text+"'", con2);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    dr2.Read();
                    if (dr["subj_code"].ToString() == dr2[op].ToString())
                    ssubj.Items.Add(dr["subj_name"].ToString());
                    dr2.Close();                   
                }
            }
            dr.Close();
            cmd = new SqlCommand("select subj_name from proj_details where class_of_subj=" + int.Parse(sclass.Text) + " and syllabus='" + ssyllabus.Text + "' and course='" + scourse.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ssubj.Items.Add(dr["subj_name"].ToString());
            }
            dr.Close();
        }

        private void optbgscor_CheckedChanged(object sender, EventArgs e)
        {
            if (optbgscor.Checked)
            {
                if (smarkstype.Text == "Dissertation")
                    ct = "marks";
                sattno.Enabled = true;
            }
        }            
    }
}

