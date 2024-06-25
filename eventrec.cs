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
    public partial class eventrec : Form
    {        
        SqlCommand cmd;
        SqlDataReader dr;
        bool edmd;
        string en;
        DateTime ed;
        public eventrec()
        {
            InitializeComponent();    
        }
        public eventrec(string en,DateTime ed)
        {
            InitializeComponent();
            this.en=en;
            this.ed=ed;
            cmd = new SqlCommand("select * from event where e_name='" + en+"' and dateofe='"+ed+"'",mainapms.con);
            dr = cmd.ExecuteReader();
            dr.Read();
            sEvttype.Text = dr["event_type"].ToString();
            eventdate.Value=Convert.ToDateTime(dr["dateofe"].ToString());
            if (!dr.IsDBNull(2))
            {
                optconstime.Enabled = true;
                timeevent.Value = Convert.ToDateTime(dr["timeofe"].ToString());
            }
            textename.Text = dr["e_name"].ToString();
           textedesc.Text = dr["e_descr"].ToString();
           sremtype.Text = dr["re_type"].ToString();
           textremtgap.Text = dr["tgap"].ToString();
           edmd = true;
           dr.Close();
        }
              private void bttnrecevent_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("select * from event", mainapms.con);
                if (!edmd)
                {
                    if (textremtgap.Enabled & optconstime.Checked)
                        cmd.CommandText = "Insert into event values('" + sEvttype.Text + "','" + eventdate.Value.Date + "','" + timeevent.Value.ToShortTimeString() + "','" + textename.Text + "','" + textedesc.Text + "','" + sremtype.Text + "'," + int.Parse(textremtgap.Text) + ")";
                    else if (textremtgap.Enabled)
                        cmd.CommandText = "Insert into event values('" + sEvttype.Text + "','" + eventdate.Value.Date + "',NULL,'" + textename.Text + "','" + textedesc.Text + "','" + sremtype.Text + "'," + int.Parse(textremtgap.Text) + ")";
                    else if (optconstime.Checked)
                        cmd.CommandText = "Insert into event values('" + sEvttype.Text + "','" + eventdate.Value.Date + "','" + timeevent.Value.ToShortTimeString() + "','" + textename.Text + "','" + textedesc.Text + "','" + sremtype.Text + "',NULL)";
                    else
                        cmd.CommandText = "Insert into event values('" + sEvttype.Text + "','" + eventdate.Value.Date + "',NULL,'" + textename.Text + "','" + textedesc.Text + "','" + sremtype.Text + "',NULL)";

                }
                else
                {
                    if (textremtgap.Enabled & optconstime.Checked)
                        cmd.CommandText = "Update event set event_type='" + sEvttype.Text + "',dateofe='" + eventdate.Value.Date + "',timeofe='" + timeevent.Value.ToShortTimeString() + "',e_name='" + textename.Text + "',e_descr='" + textedesc.Text + "',re_type='" + sremtype.Text + "',tgap=" + int.Parse(textremtgap.Text) + "where e_name='" + en + "' and dateofe='" + ed + "'";
                    else if (textremtgap.Enabled)
                        cmd.CommandText = "Update event set event_type='" + sEvttype.Text + "',dateofe='" + eventdate.Value.Date + "',timeofe=NULL,e_name='" + textename.Text + "',e_descr='" + textedesc.Text + "',re_type='" + sremtype.Text + "',tgap=" + int.Parse(textremtgap.Text) + "where e_name='" + en + "' and dateofe='" + ed + "'";
                    else if (optconstime.Checked)
                        cmd.CommandText = "Update event set event_type='" + sEvttype.Text + "',dateofe='" + eventdate.Value.Date + "',timeofe='" + timeevent.Value.ToShortTimeString() + "',e_name='" + textename.Text + "',e_descr='" + textedesc.Text + "',re_type='" + sremtype.Text + "',tgap=NULL + where e_name='" + en + "' and dateofe='" + ed + "'";
                    else
                        cmd.CommandText = "Update event set event_type='" + sEvttype.Text + "',dateofe='" + eventdate.Value.Date + "',timeofe=NULL,e_name='" + textename.Text + "',e_descr='" + textedesc.Text + "',re_type='" + sremtype.Text + "',tgap=NULL where e_name='" + en + "' and dateofe='" + ed + "'";

                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Event details stored/updated.", "Message");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
            }

        private void optconstime_CheckedChanged(object sender, EventArgs e)
        {
            timeevent.Enabled = !(timeevent.Enabled);
        }

        private void sremtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sremtype.SelectedIndex != -1)
            {
                if (sremtype.SelectedItem.ToString() == "Per x days")
                    textremtgap.Enabled = true;
                else
                {
                    textremtgap.Text = "";
                    textremtgap.Enabled = false;
                }
            }
        }

        private void bttnres_Click(object sender, EventArgs e)
        {
            sEvttype.SelectedIndex = -1;
            optconstime.Checked = false;
            textename.Text = "";
            textedesc.Text = "";
            sremtype.SelectedIndex = -1;
            textremtgap.Text = "";      
                        
            
        }
    }
}
