using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VolunTeen.Models
{
    public class VolProfileDBHandle
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
            con = new SqlConnection(constring);
        }
        public bool AddVolProfile(VolProfileModel smodel)
        {
            connection();
            SqlCommand cmd = new SqlCommand("SP_IN_VolProfile", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@FirstName", smodel.FirstName);
            cmd.Parameters.AddWithValue("@MiddleName", smodel.MiddleName);
            cmd.Parameters.AddWithValue("@LastName", smodel.LastName);
            cmd.Parameters.AddWithValue("@EmailAddress", smodel.EmailAddress);
            cmd.Parameters.AddWithValue("@DOB", smodel.DOB);

            cmd.Parameters.AddWithValue("@Gender", smodel.Gender);
            cmd.Parameters.AddWithValue("@RacialInformation", smodel.RacialInformation);
            cmd.Parameters.AddWithValue("@EthnicInformation", smodel.EthnicInformation);

            cmd.Parameters.AddWithValue("@Question1", smodel.Question1);
            cmd.Parameters.AddWithValue("@Question2", smodel.Question2);

            cmd.Parameters.AddWithValue("@StreetAddress1", smodel.StreetAddress1);
            cmd.Parameters.AddWithValue("@StreetAddress2", smodel.StreetAddress2);
            cmd.Parameters.AddWithValue("@City", smodel.City);
            cmd.Parameters.AddWithValue("@State", smodel.State);
            cmd.Parameters.AddWithValue("@ZipCode", smodel.ZipCode);

            cmd.Parameters.AddWithValue("@ContactPhone", smodel.ContactPhone);
            cmd.Parameters.AddWithValue("@CellPhone", smodel.CellPhone);
            cmd.Parameters.AddWithValue("@CurrentlyEmployed", smodel.CurrentlyEmployed);
            cmd.Parameters.AddWithValue("@PhysicalLimitation", smodel.PhysicalLimitation);
            cmd.Parameters.AddWithValue("@LimitationDescription", smodel.LimitationDescription);
            cmd.Parameters.AddWithValue("@Language", smodel.Language);

            con.Open();
            int i = cmd.ExecuteNonQuery();
           con.Close();

            if (i >= 1)
                return true;
            else
                return false;
            
        }

        public List<VolProfileModel> GetVol()
        {
            connection();
            List<VolProfileModel>  list = new List<VolProfileModel>();

            SqlCommand cmd = new SqlCommand("SP_GET_VolProfile", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                 list.Add(
                    new VolProfileModel
                    {
                       // ID = Convert.ToInt32(dr["ID"]),
                        FirstName = Convert.ToString(dr["FirstName"]),
                        MiddleName = Convert.ToString(dr["MiddleName"]),
                        LastName = Convert.ToString(dr["LastName"])
                    });
            }
            return  list;
        }
    }
}