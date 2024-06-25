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
    public partial class subjdetrec : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        string sc, cs;
        bool edmd;
        public subjdetrec()
        {
            InitializeComponent();
            edmd = false;
        }
        public subjdetrec(string sc, string cs)
        {
            InitializeComponent();
            this.sc = sc;
            this.cs = cs;
            edmd = true;
        }
        private void subjdetrec_Load(object sender, EventArgs e)
        {
            bool a;
            if (edmd)
            {                
                cmd = new SqlCommand("select * from subj_details where subj_code='" + sc + "' and course='" + cs + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                a = dr.HasRows;                
                if (!a)
                {
                    dr.Close();
                    cmd = new SqlCommand("select * from proj_details where subj_code='" + sc + "' and course='" + cs + "'", mainapms.con);
                    dr = cmd.ExecuteReader();
                }
                dr.Read();
                textsubjcode.Text = dr["subj_code"].ToString();
                textsubjname.Text = dr["subj_name"].ToString();
                scourse.Text = dr["course"].ToString();
                ssyllabus.Text = dr["syllabus"].ToString();
                if (a)
                    ssubjtype.Text = dr["subj_type"].ToString();
                else
                    ssubjtype.Text = "Project Work";
                ssubjclass.Text = dr["class_of_subj"].ToString();
                if (a)
                    textmaxia.Text = dr["maxiaexam"].ToString();
                else
                    textmaxia.Enabled = false;
                textmaxiafinal.Text = dr["maxia"].ToString();
                if (a)
                    textmmarks.Text = dr["maxmarks"].ToString();
                else
                {
                    textmaxdmarks.Enabled = true;
                    textmaxvvmarks.Enabled = true;
                    textmmarks.Enabled = false;
                    textmaxdmarks.Text = dr["maxdissertmarks"].ToString();
                    textmaxvvmarks.Text = dr["maxvivamarks"].ToString();
                }
                textminpperc.Text = dr["minpassperc"].ToString();
            }
            else
            {
                ssubjtype.SelectedIndex = 0;
                cmd = new SqlCommand("select distinct course from subj_details", mainapms.con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    scourse.Items.Add(dr["course"].ToString());
                }
                dr.Close();
                cmd = new SqlCommand("select distinct syllabus from subj_details ", mainapms.con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ssyllabus.Items.Add(dr["syllabus"].ToString());
                }               
            }
            dr.Close();
        }
        private void marks_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' & e.KeyChar <= '9' | e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void bttnsave_Click(object sender, EventArgs e)
        {
            if (!edmd)
            {
                if (ssubjtype.SelectedItem.ToString() == "Project Work")
                {
                    cmd = new SqlCommand("select * from proj_details", mainapms.con);
                    cmd.CommandText = "Insert into proj_details values('" + textsubjcode.Text + "','" + textsubjname.Text + "','" + scourse.Text + "'," + int.Parse(ssubjclass.Text) + ",'" + ssyllabus.Text + "'," + int.Parse(textmaxiafinal.Text) + "," + int.Parse(textmaxdmarks.Text) + "," + int.Parse(textmaxvvmarks.Text) + "," + int.Parse(textminpperc.Text) + ")";
                }
                else
                {
                    cmd = new SqlCommand("select * from subj_details", mainapms.con);
                   if (ssubjtype.SelectedItem.ToString() != "EC/CC")
                    cmd.CommandText = "Insert into subj_details values('" + textsubjcode.Text + "','" + textsubjname.Text + "','" + scourse.Text + "'," + int.Parse(ssubjclass.Text) + ",'" + ssyllabus.Text + "','" + ssubjtype.Text + "'," + int.Parse(textmaxia.Text) + "," + int.Parse(textmaxiafinal.Text) + "," + int.Parse(textmmarks.Text) + "," + int.Parse(textminpperc.Text) + ")";
                   else
                    cmd.CommandText = "Insert into subj_details(subj_code,subj_name,course,class_of_subj,syllabus,subj_type,maxia) values('" + textsubjcode.Text + "','" + textsubjname.Text + "','" + scourse.Text + "'," + int.Parse(ssubjclass.Text) + ",'" + ssyllabus.Text + "','" + ssubjtype.Text + "'," + int.Parse(textmaxiafinal.Text) + ")";
                }
            }
            else
            {
                if (ssubjtype.SelectedItem.ToString() == "Project Work")
                {
                    cmd = new SqlCommand("select * from proj_details", mainapms.con);
                    cmd.CommandText = "Update proj_details set subj_code='" + textsubjcode.Text + "',subj_name='" + textsubjname.Text + "',course='" + scourse.Text + "',class_of_subj=" + int.Parse(ssubjclass.Text) + ",syllabus='" + ssyllabus.Text + "',maxia=" + int.Parse(textmaxiafinal.Text) + ",maxdissertmarks=" + int.Parse(textmaxdmarks.Text) + ",maxvivamarks=" + int.Parse(textmaxvvmarks.Text) + ",minpassperc=" + int.Parse(textminpperc.Text) + "where subj_code='"+sc+"' and course='"+cs+"'";
                }
                else
                {
                    cmd = new SqlCommand("select * from subj_details", mainapms.con);
                    cmd.CommandText = "Update subj_details set subj_code='" + textsubjcode.Text + "',subj_name='" + textsubjname.Text + "',course='" + scourse.Text + "',class_of_subj=" + int.Parse(ssubjclass.Text) + ",syllabus='" + ssyllabus.Text + "',subj_type='"+ssubjtype.Text+"',maxiaexam=" + int.Parse(textmaxia.Text) +", maxia="+int.Parse(textmaxiafinal.Text)+ ",maxmarks=" + int.Parse(textmmarks.Text) + ",minpassperc=" + int.Parse(textminpperc.Text) + "where subj_code='"+sc+"' and course='"+cs+"'";
                }
            }
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Subject details recorded", "Notice");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void bttnreset_Click(object sender, EventArgs e)
        {
            try
            {
                textsubjcode.Text = "";
                textsubjname.Text = "";
                scourse.Text = "";
                ssubjclass.Text = "";
                ssyllabus.Text = "";
                ssubjtype.SelectedIndex = -1;
                textmaxia.Text = "";
                textmaxiafinal.Text = "";
                textmmarks.Text = "";
                textmaxdmarks.Text = "";
                textmaxvvmarks.Text = "";
                textminpperc.Text = "";
            }
            catch (Exception)
            { }
        }

        private void scourse_TextChanged(object sender, EventArgs e)            
        {
            if(!edmd)
            {
            ssubjclass.Items.Clear();
            cmd = new SqlCommand("select distinct class_of_subj from subj_details where course ='" + scourse.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ssubjclass.Items.Add(dr["class_of_subj"].ToString());
            }                
            dr.Close();
            }
        }

        private void ssubjtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ssubjtype.SelectedItem.ToString() == "Project Work")
            {
                textmaxdmarks.Enabled = true;
                textmaxvvmarks.Enabled = true;
                textmmarks.Enabled = false;
                textmaxia.Enabled = false;
            }
            else
            {
                textmaxdmarks.Enabled = false;
                textmaxvvmarks.Enabled = false;
                if (ssubjtype.SelectedItem.ToString() == "EC/CC")
                {
                    textmaxia.Text = "";
                    textminpperc.Text = "";
                    textmmarks.Text = "";
                    textmmarks.Enabled = false;
                    textmaxia.Enabled = false;
                    textminpperc.Enabled = false;
                }
                else
                {
                    textmmarks.Enabled = true;
                    textmaxia.Enabled = true;
                    textminpperc.Enabled = true;
                }
            }
        }
    }
}
