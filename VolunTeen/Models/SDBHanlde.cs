using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VolunTeen.Models
{
    public class SDBHanlde
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            con = new SqlConnection(constring);
        }
        public List<LoginModel> GetOpp()
        {
            connection();
            List <LoginModel> list = new List<LoginModel>();

            SqlCommand cmd = new SqlCommand("SP_LOGIN", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                 list.Add(
                    new LoginModel
                    {
                        ID = Convert.ToInt32(dr["ID"]),
                        OpportunityTitle= Convert.ToString(dr["OpportunityTitle"]),
                        OpportunityDetail = Convert.ToString(dr["OpportunityDetail"])
                     });
            }
            return list;
        }

    }
}