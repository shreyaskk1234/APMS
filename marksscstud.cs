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
    public partial class marksscstud : Form
    {
        Label sch, snh, smaxh, smminh, stminh, iamaxh, tmia1h, tmia2h, iaagmh, iah, tmh, lsmaxh, lttmh;
        Label[] sc; 
        Label[] sn;
        Label[] smax;
        Label[] smmin;
        Label[] stmin;
        Label[] iamax;
        TextBox[] tmia1;
        TextBox[] tmia2;
        Label[] iaagm;
        TextBox[] ia;
        TextBox[] tm;
        Label[] lsmax;
        Label[] lttm;
        Label lmmks;
        Label ltmks;
        Label perc;
        SqlCommand cmd;
        SqlDataReader dr;
        int c;
        bool ia1e, ia2e, tmex;
        public marksscstud()
        {
            InitializeComponent();
            c = 0;
        }

        private void marksscrecstud_Load(object sender, EventArgs e)
        {
            if (mainapms.cusert == "Student")
            {
                bttnsave.Enabled = false;
                bttndel.Enabled = false;
            }
        }        
        private void bttndisp_Click(object sender, EventArgs e)
        {
            if (textclass.Text == "")
                return;
                int i = 0;
                if (this.Controls.Contains(lmmks))
                    this.Controls.Remove(lmmks);
                if (this.Controls.Contains(ltmks))
                    this.Controls.Remove(ltmks);
                if (this.Controls.Contains(perc))
                    this.Controls.Remove(perc);
                if (this.Controls.Contains(smaxh))
                    this.Controls.Remove(smaxh);
                if (this.Controls.Contains(smminh))
                    this.Controls.Remove(smminh);
                if (this.Controls.Contains(stminh))
                    this.Controls.Remove(stmin[i]);
                if (this.Controls.Contains(iamaxh))
                    this.Controls.Remove(iamaxh);
                if (this.Controls.Contains(tmia1h))
                    this.Controls.Remove(tmia1h);
                if (this.Controls.Contains(tmia2h))
                    this.Controls.Remove(tmia2h);
                if (this.Controls.Contains(iah))
                    this.Controls.Remove(iah);
                if (this.Controls.Contains(tmh))
                    this.Controls.Remove(tmh);
                if (this.Controls.Contains(lttmh))
                    this.Controls.Remove(lttmh);
                if (this.Controls.Contains(sch))
                    this.Controls.Remove(sch);
                if (this.Controls.Contains(snh))
                    this.Controls.Remove(sn[i]);               

                for (i = 0; i < c; i++)//Clears the previous run time generated controls in window
                {
                    if (this.Controls.Contains(sc[i]))
                        this.Controls.Remove(sc[i]);
                    if (this.Controls.Contains(sn[i]))
                        this.Controls.Remove(sn[i]);
                    if (this.Controls.Contains(smax[i]))
                        this.Controls.Remove(smax[i]);
                    if (this.Controls.Contains(smmin[i]))
                        this.Controls.Remove(smmin[i]);
                    if (this.Controls.Contains(stmin[i]))
                        this.Controls.Remove(stmin[i]);
                    if (this.Controls.Contains(iamax[i]))
                        this.Controls.Remove(iamax[i]);
                    if (this.Controls.Contains(tmia1[i]))
                        this.Controls.Remove(tmia1[i]);
                    if (this.Controls.Contains(tmia2[i]))
                        this.Controls.Remove(tmia2[i]);
                    if (this.Controls.Contains(ia[i]))
                        this.Controls.Remove(ia[i]);
                    if (this.Controls.Contains(tm[i]))
                        this.Controls.Remove(tm[i]);
                    if (this.Controls.Contains(lttm[i]))
                        this.Controls.Remove(lttm[i]);
                }
                sch = new Label();
                snh = new Label();
                smaxh = new Label();
                smminh = new Label();
                stminh = new Label();
                iamaxh = new Label();
                tmia1h = new Label();
                tmia2h = new Label();
                iaagmh = new Label();
                iah = new Label();
                tmh = new Label();
                lsmaxh = new Label();
                lttmh = new Label();
                string s = "";
                i = 0;
                c = 0;
                cmd = new SqlCommand("select count(*) as c from subj_details where class_of_subj = " + int.Parse(textclass.Text) + " and course = (select course from stud_details where roll_no = '" + textrno.Text + "')", mainapms.con);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = int.Parse(dr["c"].ToString());
                    dr.Close();
                    sc = new Label[c];
                    sn = new Label[c];
                    smax = new Label[c];
                    smmin = new Label[c];
                    stmin = new Label[c];
                    iamax = new Label[c];
                    tmia1 = new TextBox[c];
                    tmia2 = new TextBox[c];
                    iaagm = new Label[c];
                    ia = new TextBox[c];
                    tm = new TextBox[c];
                    lsmax = new Label[c];
                    lttm = new Label[c];
                }
                        sch.Name = "Subj_ch";
                        sch.AutoSize = true;
                        sch.Location = new Point(10, 110);
                        sch.Text = "Subject code";
                        this.Controls.Add(sch);
                        snh.Name = "Subj_nh";
                        snh.AutoSize = true;
                        snh.Location = new Point(100,110);
                        snh.Text = "Subject name";
                        this.Controls.Add(snh);
                        iamaxh.Name = "Subjiamaxh";
                        iamaxh.AutoSize = true;
                            iamaxh.Location = new Point(325, 110);
                            iamaxh.Text = "Max IA";
                            this.Controls.Add(iamaxh);
                            tmia1h.Name = "ia1mkh";
                        iamaxh.AutoSize = true;
                            tmia1h.Location = new Point(375, 110);                                            
                            this.Controls.Add(tmia1h);
                            tmia1h.Text = "First IA";                            
                            tmia2h.Name = "ia2mh";
                        tmia2h.AutoSize = true;
                            tmia2h.Location = new Point(475, 110);
                            this.Controls.Add(tmia2h);
                            tmia2h.Text = "Second IA";
                        iaagmh.Name = "iaagmh";
                        iaagmh.AutoSize = true;
                        iaagmh.Location = new Point(525,110);
                        this.Controls.Add(iaagmh);
                        iaagmh.Text = "Max IA";
                        iah.Name = "iah";
                        iah.AutoSize = true;
                        iah.Location = new Point(575, 110);
                        this.Controls.Add(iah);
                        iah.Text = "IA";
                            smaxh.Name = "Maxmh";
                            smaxh.AutoSize = true;
                            smaxh.Location = new Point(675, 110);
                            smaxh.Text = "Max marks";
                            this.Controls.Add(smaxh);
                            smminh.Name = "Minmh";
                            smminh.AutoSize = true;
                            smminh.Location = new Point(725, 110);
                            smminh.Text = "Min marks";
                            this.Controls.Add(smminh);                          
                            tmh.Name = "Marksh";
                            tmh.AutoSize=true;
                            tmh.Location = new Point(775, 110);                            
                            this.Controls.Add(tmh);
                            tmh.Text = "Marks";
                            stminh.Name = s;
                            stminh.AutoSize = true;
                            stminh.Location = new Point(925,110);
                                stminh.Text = "Min marks";
                            this.Controls.Add(stminh);
                            lsmaxh.Name = "Subjmaxmkh";
                        lsmaxh.AutoSize = true;
                        lsmaxh.Location = new Point(875, 110);
                        this.Controls.Add(lsmaxh);
                            lsmaxh.Text = "Max marks";
                        lttmh.Name = "Subjttmkh";
                        lttmh.AutoSize = true;
                        lttmh.Location = new Point(975, 110);
                        this.Controls.Add(lttmh);
                        lttmh.Text = "Total Marks";
                cmd = new SqlCommand("select subj_code,subj_name,subj_type,maxia,maxiaexam,maxmarks,minpassperc from subj_details where class_of_subj = " + int.Parse(textclass.Text) + " and course = (select course from stud_details where roll_no = '" + textrno.Text + "')", mainapms.con);
                dr = cmd.ExecuteReader();
                bool valid = false;
                SqlConnection con2 = new SqlConnection();
                con2.ConnectionString = @" Data Source=.\SQLEXPRESS;AttachDbFilename= D:\APMS\coursedat.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True";
                con2.Open();
                SqlCommand cmd2;
                SqlDataReader dr2;
                while (dr.Read())
                {
                    valid = false;
                    if (dr["subj_type"].ToString() == "General" | dr["subj_type"].ToString() == "EC/CC")
                        valid = true;
                    if (dr["subj_type"].ToString() == "Opt Subject")
                    {
                        cmd2 = new SqlCommand("select opt_subj from stud_cl_det where roll_no='" + textrno.Text + "' and class='" + textclass.Text + "'", con2);
                        dr2 = cmd2.ExecuteReader();
                        dr2.Read();
                        if (dr2["opt_subj"].ToString() == dr["subj_code"].ToString())
                            valid = true;
                        dr2.Close();
                    }
                    if (dr["subj_type"].ToString() == "Opt Language")
                    {
                        cmd2 = new SqlCommand("select opt_lang from stud_cl_det where roll_no='" + textrno.Text + "' and class='" + textclass.Text + "'", con2);
                        dr2 = cmd2.ExecuteReader();
                        dr2.Read();
                        if (dr2["opt_lang"].ToString() == dr["subj_code"].ToString())
                            valid = true;
                        dr2.Close();
                    }
                    if (valid)
                    {
                        cmd2 = new SqlCommand("select * from stud_scor where roll_no='" + textrno.Text + "' and subj_code='" + dr["subj_code"].ToString() + "'", con2);
                        dr2 = cmd2.ExecuteReader();
                        dr2.Read();
                        if (!(dr2.HasRows))
                        {
                            dr2.Close();
                            cmd2.CommandText = "Insert into stud_scor(roll_no,subj_code) values('" + textrno.Text + "','" + dr["subj_code"].ToString() + "')";
                            cmd2.ExecuteNonQuery();
                        }
                        s = "Subj_c" + i.ToString();
                        sc[i] = new Label();
                        sc[i].Name = s;
                        sc[i].AutoSize = true;
                        sc[i].Location = new Point(10, i * 40 + 140);
                        sc[i].Text = dr["subj_code"].ToString();
                        this.Controls.Add(sc[i]);
                        s = "Subj_n" + i.ToString();
                        sn[i] = new Label();
                        sn[i].Name = s;
                        sn[i].AutoSize = true;
                        sn[i].Location = new Point(100, i * 40 + 140);
                        sn[i].Text = dr["subj_name"].ToString();
                        this.Controls.Add(sn[i]);
                        s = "Subj_iamax" + i.ToString();
                        if (dr["subj_type"].ToString() != "EC/CC")
                        {
                            iamax[i] = new Label();
                            iamax[i].Name = s;
                            iamax[i].AutoSize = true;
                            iamax[i].Location = new Point(325, i * 40 + 140);
                            iamax[i].Text = dr["maxiaexam"].ToString();
                            this.Controls.Add(iamax[i]);
                            s = "text1ia" + i.ToString();
                            tmia1[i] = new TextBox();
                            tmia1[i].Name = s;
                            tmia1[i].Size = new Size(50, 20);
                            tmia1[i].Location = new Point(375, i * 40 + 140);
                            tmia1[i].KeyPress += new KeyPressEventHandler(tmkeypress);
                            tmia1[i].Leave += new EventHandler(tmia1_leave);
                            this.Controls.Add(tmia1[i]);
                            if (!dr2.IsClosed)
                                tmia1[i].Text = dr2["IA_1m"].ToString();
                            s = "text2ia" + i.ToString();
                            tmia2[i] = new TextBox();
                            tmia2[i].Name = s;
                            tmia2[i].Size = new Size(50, 20);
                            tmia2[i].Location = new Point(475, i * 40 + 140);
                            tmia2[i].KeyPress += new KeyPressEventHandler(tmkeypress);
                            tmia2[i].Leave += new EventHandler(tmia2_leave);
                            this.Controls.Add(tmia2[i]);
                            if (!dr2.IsClosed)
                                tmia2[i].Text = dr2["IA_2m"].ToString();
                        }
                        s = "iaagm" + i.ToString();
                        iaagm[i] = new Label();
                        iaagm[i].Name = s;
                        iaagm[i].AutoSize = true;
                        iaagm[i].Location = new Point(525, i * 40 + 140);
                        iaagm[i].Text = dr["maxia"].ToString();
                        this.Controls.Add(iaagm[i]);
                        ia[i] = new TextBox();
                        ia[i].Name = s;
                        ia[i].Size = new Size(50, 20);
                        ia[i].Location = new Point(575, i * 40 + 140);
                        ia[i].KeyPress += new KeyPressEventHandler(tmkeypress);
                        this.Controls.Add(ia[i]);
                        if (!dr2.IsClosed)
                        {
                            if (!dr2.IsDBNull(4))
                                ia[i].Text = dr2["IA"].ToString();
                        }
                        if (dr["subj_type"].ToString() != "EC/CC")
                        {
                            s = "Subj_max" + i.ToString();
                            smax[i] = new Label();
                            smax[i].Name = s;
                            smax[i].AutoSize = true;
                            smax[i].Location = new Point(675, i * 40 + 140);
                            smax[i].Text = dr["maxmarks"].ToString();
                            this.Controls.Add(smax[i]);
                            s = "Subj_mmin" + i.ToString();
                            smmin[i] = new Label();
                            smmin[i].Name = s;
                            smmin[i].AutoSize = true;
                            smmin[i].Location = new Point(725, i * 40 + 140);
                            float minp = float.Parse(dr["minpassperc"].ToString());
                            int sm = int.Parse(smax[i].Text);
                            int minm = (int)(minp * sm / 100.0);
                            smmin[i].Text = minm.ToString();
                            this.Controls.Add(smmin[i]);                            
                            s = "textmainmk" + i.ToString();
                            tm[i] = new TextBox();
                            tm[i].Name = s;
                            tm[i].Size = new Size(50, 20);
                            tm[i].Location = new Point(775, i * 40 + 140);
                            tm[i].KeyPress += new KeyPressEventHandler(tmkeypress);
                            tm[i].Leave += new EventHandler(tm_leave);
                            this.Controls.Add(tm[i]);
                            if (!dr2.IsClosed)
                                tm[i].Text = dr2["marks"].ToString();
                            s = "Subj_tmin" + i.ToString();
                            stmin[i] = new Label();
                            stmin[i].Name = s;
                            stmin[i].AutoSize = true;
                            stmin[i].Location = new Point(925, i * 40 + 140);
                            int im = int.Parse(dr["maxia"].ToString());
                            if (dr["subj_type"].ToString() != "EC/CC")
                            {
                                minm = (int)(minp * (sm + im) / 100.0);
                                stmin[i].Text = minm.ToString();
                            }
                            this.Controls.Add(stmin[i]);
                        }
                        s = "maxsubjmk" + i.ToString();
                        lsmax[i] = new Label();
                        lsmax[i].Name = s;
                        lsmax[i].AutoSize = true;
                        lsmax[i].Location = new Point(875, i * 40 + 140);
                        this.Controls.Add(lsmax[i]);
                        int t = 0;
                        if (dr["subj_type"].ToString() != "EC/CC")
                        {
                            t = int.Parse(iaagm[i].Text) + int.Parse(smax[i].Text);
                            lsmax[i].Text = t.ToString();
                        }
                        else
                            lsmax[i].Text = iaagm[i].Text;
                        s = "subjtmk" + i.ToString();
                        lttm[i] = new Label();
                        lttm[i].Name = s;
                        lttm[i].AutoSize = true;
                        lttm[i].Location = new Point(975, i * 40 + 140);
                        this.Controls.Add(lttm[i]);
                        if (dr["subj_type"].ToString() != "EC/CC")
                        {
                            if (ia[i].Text != "" & tm[i].Text != "")
                            {
                                t = int.Parse(ia[i].Text) + int.Parse(tm[i].Text);
                                lttm[i].Text = t.ToString();
                            }
                        }
                        else
                            lttm[i].Text = ia[i].Text;
                        i++;
                        dr2.Close();
                    }
                }
                c = i;
                lmmks = new Label();
                lmmks.Name = "maxtotal";
                lmmks.AutoSize = true;
                lmmks.Location = new Point(875, i * 40 + 140);
                this.Controls.Add(lmmks);
                int tmaxmks = 0;
                for (i = 0; i < c; i++)
                    if (lsmax[i].Text != "")
                        tmaxmks += int.Parse(lsmax[i].Text);
                lmmks.Text = tmaxmks.ToString();
                ltmks = new Label();
                ltmks.Name = "total";
                ltmks.AutoSize = true;
                ltmks.Location = new Point(975, i * 40 + 140);
                this.Controls.Add(ltmks);
                int tmks=0;
                for(i=0;i<c;i++)
                if(lttm[i].Text!="")
                tmks += int.Parse(lttm[i].Text);                
                ltmks.Text = tmks.ToString();
                perc = new Label();
                perc.Name = "perc";
                perc.AutoSize = true;
                perc.Location = new Point(975, i * 40 + 160);
                this.Controls.Add(perc);
                perc.Text =(float)tmks / tmaxmks*100.0f+" %";
                dr.Close();
                con2.Close();          
        }
        void tmia1_leave(object sender, EventArgs e)
        {
            TextBox s=(TextBox)sender;
            int n = int.Parse(s.Name.Substring(7,1));
            if(s.Text!="")                
            ia1e = true;
            if (ia1e & ia2e)
                ia[n].Text = ((int)(((float)((int.Parse(s.Text)) + (int.Parse(tmia2[n].Text)))) / (2 * int.Parse(iamax[n].Text)) * int.Parse(iaagm[n].Text))).ToString();
        }
        void tmia2_leave(object sender, EventArgs e)
        {
            TextBox s = (TextBox)sender;            
            int n = int.Parse(s.Name.Substring(7,1));
            if (s.Text != "")
                ia2e = true;
            if (ia1e & ia2e)
                ia[n].Text = ((int)(((float)((int.Parse(tmia1[n].Text)) + (int.Parse(s.Text)))) / (2 * int.Parse(iamax[n].Text)) * int.Parse(iaagm[n].Text))).ToString();
        }
        void tm_leave(object sender, EventArgs e)
        {
            TextBox s = (TextBox)sender;
            int n = int.Parse(s.Name.Substring(10, 1));
            if (s.Text != "")
                tmex = true;
           if(ia1e & ia2e & tmex)
           {
               lttm[n].Text = (int.Parse(ia[n].Text) + int.Parse(tm[n].Text)).ToString();
                ia1e = false;
                ia2e = false;
                tmex = false;
            }
        }
        void tmkeypress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' & e.KeyChar <= '9' | e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;                     
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

        private void bttnsave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from stud_scor", mainapms.con);
            int i = 0;
            for (i = 0; i < c; i++)
            {
                try
                {
                    if (int.Parse(tmia1[i].Text) > int.Parse(iamax[i].Text))
                    {
                        MessageBox.Show("Invalid marks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tmia1[i].Focus();
                    }
                    else
                    {
                        cmd.CommandText = "Update stud_scor set IA_1m=" + int.Parse(tmia1[i].Text) + " where roll_no='" + textrno.Text + "' and subj_code='" + sc[i].Text + "'";
                        cmd.ExecuteNonQuery();                        
                    }
                }
                catch (Exception)
                {}
                try
                {
                    if (int.Parse(tmia2[i].Text) > int.Parse(iamax[i].Text))
                    {
                        MessageBox.Show("Invalid marks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tmia2[i].Focus();
                    }
                    else
                    {
                        cmd.CommandText = "Update stud_scor set IA_2m=" + int.Parse(tmia2[i].Text) + " where roll_no='" + textrno.Text + "' and subj_code='" + sc[i].Text + "'";
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {}
                try
                {
                    if (int.Parse(ia[i].Text) > int.Parse(iaagm[i].Text))
                    {
                        MessageBox.Show("Invalid marks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ia[i].Focus();
                    }
                    else
                    {
                        cmd.CommandText = "Update stud_scor set IA=" + int.Parse(ia[i].Text) + " where roll_no='" + textrno.Text + "' and subj_code='" + sc[i].Text + "'";
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception)
                {}
                try
                {
                    if (int.Parse(tm[i].Text) > int.Parse(smax[i].Text))
                    {
                        MessageBox.Show("Invalid marks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tm[i].Focus();
                    }
                    else
                    {
                        cmd.CommandText = "Update stud_scor set marks=" + int.Parse(tm[i].Text) + " where roll_no='" + textrno.Text + "' and subj_code='" + sc[i].Text + "'";
                        cmd.ExecuteNonQuery();                        
                    }
                }
                catch (Exception)
                {}
                
            }
        }

        private void bttndel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
            for(int i=0;i<c;i++)
            {
                cmd.CommandText = "Delete from stud_scor where roll_no='" + textrno.Text + "' and subj_code='" + sc[i].Text + "'";
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            }
        }

        }      
    }

    