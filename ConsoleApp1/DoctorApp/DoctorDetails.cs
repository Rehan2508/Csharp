using DoctorApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DoctorApp
{
    internal class DoctorDetails
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["NewConnection"].ToString());

        public List<Doctor> GetDoctor()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Doctor",conn);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            List<Doctor> DoctorList = new List<Doctor>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                Doctor doctor = new Doctor();
                doctor.Id = int.Parse(dataRow["Id"].ToString());
                doctor.Name = dataRow["Name"].ToString();
                doctor.HospitalName = dataRow["Hospital Name"].ToString();
                doctor.ContactNo = dataRow["ContactNo"].ToString();
                DoctorList.Add(doctor);
            }

            

            return DoctorList;
        }
    }
}
