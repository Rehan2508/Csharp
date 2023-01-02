using EmployeeApp.Dao;
using EmployeeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeOperations operations = new EmployeeOperations();
            Employee employee = new Employee();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("******MENU******");
                Console.WriteLine("Enter 1 to \'VIEW\' Table");
                Console.WriteLine("Enter 2 to \'INSERT\' into table");
                Console.WriteLine("Enter 3 to \'UPDATE\' table");
                Console.WriteLine("Enter 4 to \'DELETE\' an Employee");
                Console.WriteLine("Enter 5 to \'EXIT\'");
                Console.Write("Select an option : ");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        {
                            bool flag1 = true;
                            while (flag1)
                            {
                                Console.WriteLine("******VIEW******");
                                Console.WriteLine("Enter 1 to view the table");
                                Console.WriteLine("Enter 2 to view the employees with salary greater than the input salary");
                                Console.WriteLine("Enter 3 to view the employees of a dapartment of your choice");
                                Console.WriteLine("Enter 4 to \'EXIT VIEW\'");
                                Console.Write("Select an option : ");
                                int option = int.Parse(Console.ReadLine());
                                Console.WriteLine();

                                switch (option)
                                {
                                    case 1:
                                        {
                                            operations.Display(operations.GetEmployees());
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("Enter the Salary : ");
                                            double salary = double.Parse(Console.ReadLine());
                                            operations.Display(operations.GetEmployeesBasedOnSalary(salary));
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("Enter the department : ");
                                            string department = Console.ReadLine();
                                            operations.Display(operations.GetEmployeesBasedOnDepartment(department));
                                            break;
                                        }
                                    case 4:
                                        {
                                            flag1 = false;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid Option selection");
                                            break;
                                        }
                                }
                            }
                            
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter Employees Name : ");
                            employee.name = Console.ReadLine();
                            Console.Write("Enter Employees Salary : ");
                            employee.salary = double.Parse(Console.ReadLine());
                            Console.Write("Enter Employees Department : ");
                            employee.department = Console.ReadLine();
                            Console.WriteLine(operations.InsertEmployees(employee));
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            bool flag2 = true;
                            while (flag2)
                            {
                                Console.WriteLine("******UPDATE******");
                                Console.WriteLine("Enter 1 to update \'Name\'");
                                Console.WriteLine("Enter 2 to update \'Salary\'");
                                Console.WriteLine("Enter 3 to update \'Department\'");
                                Console.WriteLine("Enter 4 to \'Exit UPDATE\'");
                                Console.Write("Select an Option : ");
                                int option = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                switch (option)
                                {
                                    case 1:
                                        {
                                            Console.Write("Enter Employee Id : ");
                                            employee.id = int.Parse(Console.ReadLine());
                                            Console.Write("Enter the name : ");
                                            employee.name = Console.ReadLine();
                                            Console.WriteLine(operations.UpdateEmployeesName(employee));
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 2:
                                        {
                                            Console.Write("Enter Employee Id : ");
                                            employee.id = int.Parse(Console.ReadLine());
                                            Console.Write("Enter the salary : ");
                                            employee.salary = double.Parse(Console.ReadLine());
                                            Console.WriteLine(operations.UpdateEmployeesSalary(employee));
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 3:
                                        {
                                            Console.Write("Enter Employee Id : ");
                                            employee.id = int.Parse(Console.ReadLine());
                                            Console.Write("Enter the department : ");
                                            employee.department = Console.ReadLine();
                                            Console.WriteLine(operations.UpdateEmployeesDepartment(employee));
                                            Console.WriteLine();
                                            break;
                                        }
                                    case 4:
                                        {
                                            flag2 = false;
                                            break;
                                        }
                                    default:
                                        {
                                            Console.WriteLine("Invalid Option selection");
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Enter the id of the Employee : ");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine(operations.DeleteEmployees(id));
                            Console.WriteLine();
                            break;
                        }
                    case 5:
                        {
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid option selection");
                            break;
                        }
                }
            }                               
        }
    }
}
