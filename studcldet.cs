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
    public partial class studcldet : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        string r;
        string rn;
        string[] ra;
        int l;
        public studcldet()
        {
            InitializeComponent();
        }

        private void bttnsave_Click(object sender, EventArgs e)
        {          
            r = textoptsrno.Text;
            cmd = new SqlCommand("select subj_code from subj_details where subj_name='" + soptsubj.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            string sc = dr["subj_code"].ToString();
            dr.Close();
            int i = 0;
            //cmd = new SqlCommand("select * from stud_cl_det", mainapms.con);
            while (i <= r.Length)
            {
                if (i < r.Length && r[i] != '\r' && r[i] != ' ' && r[i] != '\t')
                {
                    if (r[i] != '\n')
                        rn = rn + r[i];
                }
                else
                {                    
                    if(soptsubj.SelectedIndex<l)
                    cmd.CommandText = "Update stud_cl_det set opt_subj='" + sc + "' where  roll_no='" + rn + "' and class=" + int.Parse(sclass.Text);
                    else
                    cmd.CommandText = "Update stud_cl_det set opt_lang='" + sc + "' where  roll_no='" + rn + "' and class=" + int.Parse(sclass.Text);
                    cmd.ExecuteNonQuery();
                    rn = "";
                }
                i++;
            }
           
        }

        private void studcldet_Load(object sender, EventArgs e)
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
            cmd = new SqlCommand("select distinct batch from stud_details where course='"+scourse.Text+"'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sbatch.Items.Add(dr["batch"].ToString());
            }
            dr.Close();
            string[] st={"subj","proj"};
            int i=0;
            while (i <= 1)
            {
                cmd = new SqlCommand("select distinct class_of_subj from " + st[i] + "_details where course='" + scourse.Text + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sclass.Items.Add(dr["class_of_subj"].ToString());
                }
                dr.Close();
                i++;
            }
        }

        private void sclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select subj_name from  subj_details where course='" + scourse.Text+"' and class_of_subj="+int.Parse(sclass.Text)+" and subj_type='Opt subject'" , mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                soptsubj.Items.Add(dr["subj_name"].ToString());
            }
            dr.Close();
            l = soptsubj.Items.Count - 1;
            cmd = new SqlCommand("select subj_name from  subj_details where course='" + scourse.Text + "' and class_of_subj=" + int.Parse(sclass.Text) + " and subj_type='Opt language'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                soptsubj.Items.Add(dr["subj_name"].ToString());
            }
            dr.Close();
        }

        private void bttncladdsave_Click(object sender, EventArgs e)
        {            
            int i = 0, j = -1;
            cmd = new SqlCommand("select count(*) as c from stud_details where course='" + scourse.Text + "' and batch='" + sbatch.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            int c = int.Parse(dr["c"].ToString());
            dr.Close();
            r = textexrno.Text;
            rn = "";
            ra = new string[c];
            cmd = new SqlCommand("select roll_no from stud_details where course='" + scourse.Text + "' and batch='" + sbatch.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (i < r.Length)
            {
                if (i < r.Length & r[i] != '\r' & r[i] != ' ')
                {
                    if (r[i + 1] != '\n')
                        rn = rn + r[i];
                }
                else
                    ra[++j] = rn;
                i++;
            }
            SqlConnection con2 = new SqlConnection();
            con2.ConnectionString = @" Data Source=.\SQLEXPRESS;AttachDbFilename= D:\APMS\coursedat.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True";
            con2.Open();
            SqlCommand cmd2 = new SqlCommand("select * from stud_cl_det", con2);
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
                        cmd2.CommandText = "Update stud_cl_det set start_date='" + dateclssadm.Value.Date + "' where  roll_no='" + dr["roll_no"].ToString() + "' and class=" + int.Parse(sclass.Text);
                    else
                        cmd2.CommandText = "Insert into stud_cl_det(roll_no,class,start_date) values('" + dr["roll_no"].ToString() + "'," + int.Parse(sclass.Text) + ",'" + dateclssadm.Value.Date + "')";
                    cmd2.ExecuteNonQuery();
                }
            }
            dr.Close();
            
            }
        }

    }

