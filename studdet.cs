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
    public partial class studdet : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        string[] rn;
        public studdet()
        {
            InitializeComponent();
        }
        private void studdetrec_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select distinct course from subj_details", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                scourse.Items.Add(dr["course"].ToString());
            }
            dr.Close();
            cmd = new SqlCommand("select distinct batch from stud_details ", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sbatch.Items.Add(dr["batch"].ToString());
            }
            dr.Close();
                        
            if (mainapms.cusert == "Student")
            {
                bttcldatsave.Enabled = false;
                bttndel.Enabled = false;
                bttnsave.Enabled = false;
                bttnspd.Enabled = false;
                optedmd.Enabled = false;
            }
        }
        private void bttnselph_Click(object sender, EventArgs e)
        {
            OpenFileDialog a =new OpenFileDialog();
            if (a.ShowDialog() == DialogResult.OK)
                studpict.Image = Image.FromFile(a.FileName);
        }
        private void bttncadmdetsave_Click(object sender, EventArgs e)
        {
            string sc;
            cmd=new SqlCommand("select * from stud_cl_det",mainapms.con);
            try
            {
                cmd.CommandText = "Insert stud_cl_det(roll_no,class) values('" + textsrno.Text + "'," + sclass.Text + ")";
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            { }            
            cmd = new SqlCommand("select subj_code from subj_details where subj_name='" + soptsubj.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();            
            if (dr.Read())
            {
                sc = dr["subj_code"].ToString();
                dr.Close();                                 
                cmd.CommandText = "Update stud_cl_det set start_date='"+dateclssadm.Value.Date+"' opt_subj='" + sc + "' where roll_no='" + textsrno.Text + "' and class=" + sclass.Text;
                cmd.ExecuteNonQuery();
            }
            if(!dr.IsClosed)
                dr.Close();
            cmd = new SqlCommand("select subj_code from subj_details where subj_name='" + soptlang.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                sc = dr["subj_code"].ToString();
                dr.Close();
                cmd.CommandText = "Update stud_cl_det set start_date='" + dateclssadm.Value.Date + "' opt_lang='" + sc + "' where roll_no='" + textsrno.Text + "' and class=" + sclass.Text;
                cmd.ExecuteNonQuery();
            }
            if (!dr.IsClosed)
                dr.Close();
            //cmd = new SqlCommand("select lsno from lect_sess_tim where subj_code='" + soptsubj.Text + "'", mainapms.con);
            //dr = cmd.ExecuteReader();
            //dr.Read();         

        }       
        private void bttnsave_Click(object sender, EventArgs e)
        {                     
            cmd = new SqlCommand("select * from stud_details", mainapms.con);
            if (optedmd.Checked)
                cmd.CommandText = "Update stud_details set s_name='" + textstudname.Text + "', reg_no='" + textregno.Text + "' ,course='" + scourse.Text + "' ,batch='" + sbatch.Text + "' ,syllabus='" + ssyllabus.Text + "' where roll_no='"+textsrno.Text+"'";
            else
            cmd.CommandText = "Insert into stud_details values('" + textsrno.Text + "','" + textstudname.Text + "','" + textregno.Text + "','" + scourse.Text + "','" + sbatch.Text + "','" + ssyllabus.Text + "')";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student details recorded", "Notice");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!optedmd.Checked)
            {
                cmd = new SqlCommand("select * from user_login", mainapms.con);
                cmd.CommandText = "Insert into user_login values('" + textsrno.Text + "','" + textsrno.Text + "')";
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
            }
        }

        private void bttnspd_Click(object sender, EventArgs e)
        {
            char gender;
            if (optgm.Checked == true)
                gender = 'M';
            else
                gender = 'F';
            cmd = new SqlCommand("select * from stud_details", mainapms.con);
            if(optedmd.Checked)
                cmd.CommandText = "Update studpd set gender= '" + gender + "',dateofb='" + dateofbirth.Value.Date + "',address='" + textaddr.Text + "',photo_addr='" + studpict.ImageLocation + "',caste='" + textcaste.Text + "',religion='" + sreligion.Text + "' where roll_no= + '"+textsrno.Text + "'";
            else
            cmd.CommandText = "Insert into studpd values('" + textsrno.Text + "','" + gender + "','" + dateofbirth.Value.Date + "','" + textaddr.Text + "','" + studpict.ImageLocation + "','" + textcaste.Text + "','" + sreligion.Text + "')";
            cmd.ExecuteNonQuery();
        }      

        private void bttnsear_Click(object sender, EventArgs e)
        {
            int i=0;
            searchlist.Items.Clear();
           cmd = new SqlCommand("select count(*) as c from stud_details where roll_no like '" + textsrno.Text + "' and s_name like '" + textstudname.Text + "' and reg_no like '" + textregno.Text + "' and course = '" + scourse.Text + "' and batch = '" + sbatch.Text + "'", mainapms.con);
           dr=cmd.ExecuteReader();
           dr.Read(); 
           int c=int.Parse(dr["c"].ToString());
           rn = new string[c];
           dr.Close();
            cmd = new SqlCommand("select s_name,roll_no from stud_details where roll_no like '"+textsrno.Text+"' and s_name like '"+textstudname.Text +"' and reg_no like '"+textregno.Text+"' and course = '"+ scourse.Text+"' and batch = '"+sbatch.Text+"' and syllabus='"+ssyllabus.Text+"'" , mainapms.con);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                searchlist.Items.Add(dr["s_name"].ToString());
               rn[i++]=dr["roll_no"].ToString();
            }
            dr.Close();
        }

        private void bttnviewed_Click(object sender, EventArgs e)
        {
            optedmd.Checked = true;
            cmd = new SqlCommand("select * from stud_details where roll_no='"+rn[searchlist.SelectedIndices[0]]+"'", mainapms.con);
            dr = cmd.ExecuteReader();            
            dr.Read();
            textsrno.Text = dr["roll_no"].ToString();
            textstudname.Text = dr["s_name"].ToString();
            textregno.Text = dr["reg_no"].ToString();
            scourse.Text = dr["course"].ToString();
            sbatch.Text=dr["batch"].ToString();
            ssyllabus.Text=dr["syllabus"].ToString();
            dr.Close();
            cmd=new SqlCommand("select max(class) as cl from stud_cl_det where roll_no='" + rn[searchlist.SelectedIndices[0]] + "'", mainapms.con);
            dr = cmd.ExecuteReader();            
            dr.Read();
            sclass.Text=dr["cl"].ToString();
            dr.Close();
            cmd = new SqlCommand("select * from studpd where roll_no='" + rn[searchlist.SelectedIndices[0]] + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                studpict.Image = Image.FromFile(dr["photo_addr"].ToString());
                if (dr["gender"].ToString() == "M")
                    optgm.Checked = true;
                else
                    optgf.Checked = true;
                textaddr.Text = dr["address"].ToString();
                dateofbirth.Value = Convert.ToDateTime(dr["dateofb"].ToString());
                textcaste.Text = dr["caste"].ToString();
                sreligion.Text = dr["religion"].ToString();
            }
            dr.Close();
        }

        private void sclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            soptsubj.Items.Clear();          
                cmd = new SqlCommand("select subj_name from  subj_details where course='" + scourse.Text + "' and class_of_subj=" + int.Parse(sclass.Text) + " and subj_type='Opt subject'", mainapms.con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    soptsubj.Items.Add(dr["subj_name"].ToString());
                }
                dr.Close();
                cmd = new SqlCommand("select subj_name from  subj_details where course='" + scourse.Text + "' and class_of_subj=" + int.Parse(sclass.Text) + " and subj_type='Opt language'", mainapms.con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    soptlang.Items.Add(dr["subj_name"].ToString());
                }
                dr.Close();
                string ss = "", sl = "";
                cmd = new SqlCommand("select start_date ,opt_subj,opt_lang from stud_cl_det where roll_no='" + textsrno.Text + "' and class='" + sclass.Text + "'", mainapms.con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dateclssadm.Value = Convert.ToDateTime(dr["start_date"].ToString());
                    ss = dr["opt_subj"].ToString();
                    sl = dr["opt_lang"].ToString();
                }
                dr.Close();         
                    cmd = new SqlCommand("select subj_name from  subj_details where subj_code='" + ss + "'", mainapms.con);
                    dr = cmd.ExecuteReader();
                    if(dr.Read())
                    soptsubj.Text = dr["subj_name"].ToString();
                    dr.Close();                  
                    cmd = new SqlCommand("select subj_name from  subj_details where subj_code='" + sl + "'", mainapms.con);
                    dr = cmd.ExecuteReader();
                    if(dr.Read())
                    soptlang.Text = dr["subj_name"].ToString();
                    dr.Close();     
                 }

        private void bttnreset_Click(object sender, EventArgs e)
        {
            textstudname.Text = "";
            textsrno.Text = "";
            textregno.Text = "";
            scourse.SelectedIndex = -1;
            sbatch.SelectedIndex = -1;
            ssyllabus.SelectedIndex = -1;
        }

        private void bttnrespd_Click(object sender, EventArgs e)
        {
            studpict.ImageLocation = "";
            optgm.Checked = false;
            optgf.Checked = false;
            textaddr.Text = "";
            textcaste.Text = "";
            sreligion.SelectedIndex = -1;

        }

        private void bttndel_Click(object sender, EventArgs e)
        {
            bttnviewed_Click(sender,e);
            if(MessageBox.Show("Are you sure you want to delete all data of student?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    cmd = new SqlCommand("select * from stud_atte_dat", mainapms.con);
                    cmd.CommandText = "Delete from stud_atte_dat where roll_no='" + textsrno.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
                try
                {
                    cmd = new SqlCommand("select * from stud_scor", mainapms.con);
                    cmd.CommandText = "Delete from stud_scor where roll_no='" + textsrno.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
                try
                {
                    cmd = new SqlCommand("select * from stubg_scor", mainapms.con);
                    cmd.CommandText = "Delete from stubg_scor where roll_no='" + textsrno.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
                try
                {
                    cmd = new SqlCommand("select * from stud_proj_scor", mainapms.con);
                    cmd.CommandText = "Delete from stud_proj_scor where roll_no='" + textsrno.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
                try
                {
                    cmd = new SqlCommand("select * from stud_cl_det", mainapms.con);
                    cmd.CommandText = "Delete from stud_cl_det where roll_no='" + textsrno.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
                try
                {
                    cmd = new SqlCommand("select * from studpd", mainapms.con);
                    cmd.CommandText = "Delete from studpd where roll_no='" + textsrno.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
                try
                {
                    cmd = new SqlCommand("select * from stud_details", mainapms.con);
                    cmd.CommandText = "Delete from stud_details where roll_no='" + textsrno.Text + "'";
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                { }
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

        private void sclass_Click(object sender, EventArgs e)
        {
            sclass.Items.Clear();
            cmd = new SqlCommand("select distinct class_of_subj from subj_details where course='" + scourse.Text + "' and syllabus ='"+ssyllabus.Text+"'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sclass.Items.Add(dr["class_of_subj"].ToString());
            }
            dr.Close();
            cmd = new SqlCommand("select distinct class_of_subj from proj_details where course='" + scourse.Text + "' and syllabus ='" + ssyllabus.Text + "'", mainapms.con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sclass.Items.Add(dr["class_of_subj"].ToString());
            }
            dr.Close();
        }

        private void searchlist_SelectedIndexChanged(object sender, EventArgs e)
        {
             if(searchlist.SelectedIndex!=-1)
           bttnviewed.Enabled = true;
            else
                 bttnviewed.Enabled = false;
        }             
       }
}
