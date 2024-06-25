using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace APMS
{
    class calcpercattd
    {
        string rn,sc;
        public calcpercattd ()
        {}
        public calcpercattd(string roll_no,string subj_code)
        {
            rn=roll_no;
            sc=subj_code;
        }
        public void setargs(string roll_no,string subj_code)
        {
            rn=roll_no;
            sc=subj_code;
        }
        public float calc()
        {               
            SqlCommand cmd=new SqlCommand("select max(lsno) as ls from stud_atte_dat where roll_no='"+rn+"' and subj_code='"+sc+"'",mainapms.con);
            SqlDataReader dr;            
                dr = cmd.ExecuteReader();
                int ls = 0;
                try
                {
                    dr.Read();
                    ls = int.Parse(dr["ls"].ToString());
                    dr.Close();
                }
                catch (Exception)
                {                    
                    dr.Close();
                }           
                cmd = new SqlCommand("select min(lsno) as stls from lect_sess_tim where dt_of_ls>=(select start_date from stud_cl_det where roll_no='" + rn + "' and class=(select class_of_subj from subj_details where subj_code='" + sc + "'))", mainapms.con);
                dr = cmd.ExecuteReader();
                int stls = 0;
                try
                {
                    dr.Read();
                    stls = int.Parse(dr["stls"].ToString());
                    dr.Close();
                }
                catch (Exception)
                {
                    dr.Close();
                }   
                cmd = new SqlCommand("select count(*) as ps from stud_atte_dat where roll_no='" + rn + "' and subj_code='" + sc + "' and attendance='true'", mainapms.con);
                dr = cmd.ExecuteReader();
                int ps = 0;
                try
                {
                    dr.Read();
                    ps = int.Parse(dr["ps"].ToString());
                    dr.Close();
                }
                catch (Exception)
                {
                    dr.Close();
                }  
                float perc = (float)ps / (ls - stls + 1) * 100.0f;
                return perc;
           
        }       

    }
}
