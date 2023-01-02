using EmployeeApp.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Dao
{
    internal class EmployeeOperations : EmployeeOperationInterface
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["EmployeeConnection"].ToString());

        public void Display(List<Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                string str = String.Format("{0,-2}|{1,-15}|{2,-10}|{3,-15}", employee.id, employee.name, employee.salary, employee.department);
                Console.WriteLine(str);
                //Console.Write($"{employee.id}".PadRight(5));
                //Console.Write($"| {employee.name}".PadRight(5));
                //Console.Write($"| {employee.salary}".PadRight(5));
                //Console.Write($"| {employee.department}".PadRight(5));
                //Console.WriteLine();

                //Console.WriteLine($"{employee.id} | {employee.name} | {employee.salary} | {employee.department}");
            }

            Console.WriteLine();
        }

        public List<Employee> GetEmployees()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employee",conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Employee> employees = new List<Employee>();
            foreach (DataRow dr in dt.Rows)
            {
                Employee employee = new Employee();
                employee.id = int.Parse(dr["Id"].ToString());
                employee.name = dr["Name"].ToString();
                employee.salary = int.Parse(dr["Salary"].ToString());
                employee.department = dr["Department"].ToString();
                employees.Add(employee);
            }

            return employees;
        }

        public List<Employee> GetEmployeesBasedOnSalary(double salary) 
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employee WHERE Salary > '"+salary+"'",conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Employee> employees = new List<Employee>();
            foreach(DataRow dr in dt.Rows)
            {
                Employee employee=new Employee();
                employee.id = int.Parse(dr["Id"].ToString());
                employee.name = dr["Name"].ToString();
                employee.salary = int.Parse(dr["Salary"].ToString());
                employee.department = dr["Department"].ToString();
                employees.Add(employee);
            }

            return employees;
        }

        public List<Employee> GetEmployeesBasedOnDepartment(string department)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM EMployee WHERE Department = '"+department+"'",conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            List<Employee> employees = new List<Employee>();
            foreach(DataRow dr in dt.Rows)
            {
                Employee employee = new Employee();
                employee.id = int.Parse(dr["Id"].ToString());
                employee.name=dr["Name"].ToString();
                employee.salary = int.Parse(dr["Salary"].ToString());
                employee.department = dr["Department"].ToString();
                employees.Add(employee);
            }

            return employees;
        }

        public string InsertEmployees(Employee employee)
        {
            String message = "Insert is Successful";
            SqlCommand cmd = new SqlCommand("INSERT INTO Employee ([Name],Salary,Department) VAlUES ('"+employee.name+"','"+employee.salary+"','"+employee.department+"')",conn);
            try 
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch (Exception ex)
            {
                message = "Insert Unsuccessful" + ex.Message;
                return message;
            }
            finally
            {
                conn.Close();
            }
        }

        public string UpdateEmployeesName(Employee employee)
        {
            String message = "Update is successful";
            SqlCommand cmd = new SqlCommand("UPDATE Employee SET Name = '" + employee.name + "' WHERE Id = '" + employee.id + "'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch (Exception ex)
            {
                message = "Update is Unsuccessful " + ex.Message;
                return message;
            }
            finally
            {
                conn.Close();
            }
        }

        public string UpdateEmployeesSalary(Employee employee)
        {
            String message = "Update is successful";
            SqlCommand cmd = new SqlCommand("UPDATE Employee SET Salary = '" + employee.salary + "' WHERE Id = '" + employee.id + "'", conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch (Exception ex)
            {
                message = "Update is Unsuccessful " + ex.Message;
                return message;
            }
            finally
            {
                conn.Close();
            }
        }

        public string UpdateEmployeesDepartment(Employee employee)
        {
            String message = "Update is successful";
            SqlCommand cmd = new SqlCommand("UPDATE Employee SET Department = '"+employee.department+"' WHERE Id = '"+employee.id+"'",conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch(Exception ex)
            {
                message = "Update is Unsuccessful " + ex.Message;
                return message;
            }
            finally
            {
                conn.Close();
            }
        }

        public string DeleteEmployees(int id)
        {
            string message = "Delete Successful";
            SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Id = '"+id+"'",conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                return message;
            }
            catch(Exception ex)
            {
                message = "Delete Unsuccessful " + ex.Message;
                return message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
