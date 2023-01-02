using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using AssignmentDAL.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AssignmentDAL
{
    public class CRUD
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConnection"].ToString());

        public void CheckEmployeeInDB(int Id)
        {
            SqlCommand cmd = new SqlCommand("findEmployeeWithId", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", Id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt != null)
            {
                if (dt.Rows.Count == 0)
                    Console.WriteLine("Invalid Employee Id");
                else
                {
                    /*
                    Employee employee = new Employee();
                    foreach (DataRow dr in dt.Rows)
                    {
                        employee.id = int.Parse(dr["Id"].ToString());
                        employee.name = dr["Name"].ToString();
                        employee.salary = double.Parse(dr["Salary"].ToString());
                        employee.department = dr["Department"].ToString();
                    }*/
                    Console.WriteLine($"{dt.Rows[0]["Id"]} | {dt.Rows[0]["Name"]} | {dt.Rows[0]["Salary"]} | {dt.Rows[0]["Department"]}");
                    //Console.WriteLine($"{employee.id} | {employee.name} | {employee.salary} | {employee.department}");
                }
                //Console.ReadLine();
            }
        }
    }
        
}
