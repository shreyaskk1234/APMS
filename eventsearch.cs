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
    public partial class eventsearch : Form
    {
        
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public eventsearch()
        {
            InitializeComponent();
            
        }

        private void eventsearch_Load(object sender, EventArgs e)
        {
            if (mainapms.cusert == "Student")
            {
                bttndelevents.Enabled = false;
                bttnedev.Enabled = false;
            }
                
        }

        private void bttndispevents_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            if (sEvttype.Text == "All")
            da = new SqlDataAdapter(" select * from event where e_name like '" + textename.Text + "' and dateofe between '" + eventstdate.Value.Date + "' and '" + eventenddate.Value.Date + "'", mainapms.con);
            else
            da = new SqlDataAdapter(" select * from event where event_type='" + sEvttype.Text + "' and e_name like '" + textename.Text + "' and dateofe between '" + eventstdate.Value.Date + "' and '" + eventenddate.Value.Date + "'", mainapms.con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void bttnedev_Click(object sender, EventArgs e)
        {
            DateTime ed = Convert.ToDateTime((dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));
            string en = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            eventrec er = new eventrec(en,ed);
            er.Show();
        }

        private void bttndelevents_Click(object sender, EventArgs e)
        {
            DateTime ed = Convert.ToDateTime((dataGridView1.SelectedRows[0].Cells[1].Value.ToString()));
            string en = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            cmd = new SqlCommand("select * from event where e_name='" + en+"' and dateofe='"+ed+"'",mainapms.con);
            cmd.CommandText="delete from event where e_name='" + en+"' and dateofe='"+ed+"'";
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            da = new SqlDataAdapter(" select * from event where event_type='" + sEvttype.Text + "' and e_name like '" + textename.Text + "' and dateofe between '" + eventstdate.Value.Date + "' and '" + eventenddate.Value.Date + "'", mainapms.con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        
        }
}
