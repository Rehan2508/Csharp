using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DBConnectExample.Models;

namespace DBConnectExample
{
    internal class HospitalDetails
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString());

        public List<Patient> GetPatient()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Patient",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            List<Patient> ptlist = new List<Patient>();
            foreach (DataRow dataRow in dt.Rows)
            {
                Patient p = new Patient();
                p.id = int.Parse(dataRow["Id"].ToString());
                p.name = dataRow["Name"].ToString();
                p.ailment = dataRow["Ailment"].ToString();
                ptlist.Add(p);
            }
            return ptlist;
        }

        //sql data adapter is a disconnection architecture : we dont have to manually open or close the cpnnection
        public string InsertNewPatient(Patient p)
        {
            string message = "Success insertion of record";
            SqlCommand cmd = new SqlCommand("INSERT INTO Patient ([Name],ailment,Id) VALUES ('"+p.name+"','"+p.ailment+"','"+p.id+"')", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch(Exception ex)
            {
                message = "Error in insertion " + ex.Message;
                return message;
            }
            finally
            {
                con.Close();
            }
        }

        public string UpdatePateint(Patient p)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Patient SET name = '"+p.name+"' WHERE Id = '"+p.id+"'",con);
            string message = "Update successful";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch(Exception ex)
            {
                message = "Update unsuccessful : " + ex.Message;
                return message;
            }
            finally
            {
                con.Close();
            }
        }

        public string DeletePatient(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Patient WHERE Id = '"+id+"'",con);
            String message = "Deletion Successful";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch(Exception ex)
            {
                message = "Deletion Unsuccessful " + ex.Message;

                return message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
