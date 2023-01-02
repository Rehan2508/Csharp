using EmployeeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Dao
{
    internal interface EmployeeOperationInterface
    {
        List<Employee> GetEmployees();
        List<Employee> GetEmployeesBasedOnSalary(double salary);
        List<Employee> GetEmployeesBasedOnDepartment(string department);
        string InsertEmployees(Employee employee);
        string UpdateEmployeesDepartment(Employee employee);
        string UpdateEmployeesName(Employee employee);
        string UpdateEmployeesSalary(Employee employee);
        string DeleteEmployees(int id);
        void Display(List<Employee> employeeList);

    }
}
