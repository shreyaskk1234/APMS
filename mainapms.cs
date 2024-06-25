using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace APMS
{
    public partial class mainapms : Form
    {
        public static SqlConnection con;
        login l;
        public static string cuser;
        public static string cusert;
        SqlCommand cmd;
        SqlDataReader dr;
        public mainapms()
        {
            InitializeComponent();
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @" Data Source=.\SQLEXPRESS;AttachDbFilename= D:\APMS\coursedat.mdf ;Integrated Security=True;Connect Timeout=30;User Instance=True";
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login ls = new login(true);
            ls.Show();
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attdrec a = new attdrec();
            a.Show();
        }

        private void sessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attdretsess a = new attdretsess();
            a.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentAndSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attdretstud a = new attdretstud();
            a.Show();
        }

        private void percentageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attdpercret a = new attdpercret();
            a.Show();
        }

        private void recordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            eventrec er = new eventrec();
            er.Show();
        }

        private void retrieveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            eventsearch es = new eventsearch();
            es.Show();
        }

        private void changeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lectdetreg l = new lectdetreg();
            l.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cuser = "";
            l = new login(false);
            l.Show();
            Program.apms.Enabled = false;

        }
        private void recordToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            subjdetrec s = new subjdetrec();
            s.Show();
        }

        private void retrieveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            subjdetsear s = new subjdetsear();
            s.Show();
        }

        private void mainapms_Load(object sender, EventArgs e)
        {
            l = new login(false);
            l.Show();
            this.Enabled = false;
            l.Focus();
        }

        private void recordToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            marksscor m = new marksscor();
            m.Show();
        }            

        public void start()
        {
            if (cuser == "admin")
                cusert = "Admin";
            else
            {
                cmd = new SqlCommand("select lecturer_id from lecturer_det where lecturer_id='" + cuser + "'", con);
                dr = cmd.ExecuteReader();                
                if (dr.Read())
                    cusert = "Lecturer";
                dr.Close();
                cmd = new SqlCommand("select roll_no from stud_details where roll_no='" + cuser + "'", con);
                dr = cmd.ExecuteReader();                
                if (dr.Read())
                    cusert = "Student";
                dr.Close();
            }
            if (cusert == "Student")
            {
                attdrecm.Enabled = false;
                eventrecm.Enabled = false;
                recordToolStripMenuItem2.Enabled = false;
                classdetmnit.Enabled = false;
            }
            curuser.Text = "User name: " + cuser;
            curusertype.Text = "User Type: " + cusert;
            cmd = new SqlCommand("select e_name,dateofe from event where re_type='Startup'", con);
            dr = cmd.ExecuteReader();
            string m = "";
            int d,h,mt;            
            TimeSpan t;
            /* The code reads the details of each event of reminder type one by one and concatenates the data of the event with the notification message except the events which are before current date*/
            while (dr.Read())
            {
                t = Convert.ToDateTime(dr["dateofe"]).Subtract(DateTime.Now);
                d = t.Days; h = t.Hours; mt = t.Minutes;
                if (d == 0 & h<0 & mt<0)
                    m += "Todays Event: " + dr["e_name"] + "\n";                 
                   
                else if (d > 0|(d==0 & h>0 & mt>0))
                {
                    d++;
                    m += "Event:" + dr["e_name"] + " Date of Event: " + Convert.ToDateTime(dr["dateofe"]).Date.ToShortDateString() + " No of days remaining: " + d + "\n";
                }
            }
            dr.Close();
            cmd = new SqlCommand("select e_name,dateofe,tgap from event where re_type='Per x days'", con);
            dr = cmd.ExecuteReader();//Retrieve details of events from db
            int tgap;
            /* The code reads the details of each event of reminder type Per x days  one by one and concatenates the data of the event with the notification message except the events which are before current date and which do not match time gap specified*/
            while (dr.Read())
            {
                t = Convert.ToDateTime(dr["dateofe"]).Subtract(DateTime.Now);
                tgap = int.Parse(dr["tgap"].ToString());
                d = t.Days; h = t.Hours; mt = t.Minutes;

                if (d == 0 & h < 0 & mt < 0)
                        m += "Todays Event: " + dr["e_name"] + "\n";
                else if ((d > 0|d==0& h>0& mt>0) & (d % tgap == 0))
                {
                    d++;
                    m += "Event:" + dr["e_name"] + " Date of Event:" + dr["dateofe"] + " No of days remaining: " + d + "\n";
                }
            }
            if (m != "")
                MessageBox.Show(m, "Notice");
            dr.Close();
            Program.apms.Focus();
            welcpict.Image=Image.FromFile("welcome.gif");
            timer.Enabled=true;            
        }

        private void allDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studdet sd = new studdet();
            sd.Show();
        }

        private void classDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studcldet sd = new studcldet();
            sd.Show();
        }

        private void sttimer_Tick(object sender, EventArgs e)
        {
        welcpict.Visible=false;
        }

        private void marksScoreOfAClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            marksscstud ms = new marksscstud();
            ms.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.Show();
            this.Enabled = false;
        }
    }
}
