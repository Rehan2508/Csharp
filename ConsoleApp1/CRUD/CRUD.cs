using DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CRUD
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyCOnnection"].ToString());
        
        public List<Employee> fetchEmployees()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employee", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Employee> employees = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                Employee employee = new Employee();
                employee.id = int.Parse(dr["Id"].ToString());
                employee.name = dr["Name"].ToString();
                employee.salary = double.Parse(dr["Salary"].ToString());
                employee.department = dr["Department"].ToString();
                employees.Add(employee);
            }
            return employees;
        }

        public List<Employee> fetchEmployees1()
        {
            SqlCommand cmd = new SqlCommand("SPEmployeeList1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            List<Employee> employees = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                Employee employee = new Employee();
                employee.id = int.Parse(dr["Id"].ToString());
                employee.name = dr["Name"].ToString();
                employee.salary = double.Parse(dr["Salary"].ToString());
                employee.department = dr["Department"].ToString();
                employees.Add(employee);
            }
            return employees;
        }

        public List<Employee> fetchEmployees2(double Salary)
        {
            SqlCommand cmd = new SqlCommand("SPEmployeeList1", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            
            cmd.Parameters.AddWithValue("@Salary", Salary);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            List<Employee> employees = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                Employee employee = new Employee();
                employee.id = int.Parse(dr["Id"].ToString());
                employee.name = dr["Name"].ToString();
                employee.salary = double.Parse(dr["Salary"].ToString());
                employee.department = dr["Department"].ToString();
                employees.Add(employee);
            }
            return employees;
        }
    }
}
