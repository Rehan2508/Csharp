using DAL.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExample
{
    internal class Program
    {

        public static void Display(List<Employee> list)
        {
            foreach (Employee employee in list)
            {
                string str = String.Format("{0,-5}|{1,-15}|{2,-15}|{3,-15}", employee.id, employee.name, employee.salary, employee.department);
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            CRUD cr = new CRUD();
            Console.WriteLine("******Normal******");
            Display(cr.fetchEmployees());
            //Console.WriteLine("******Stored Procedure******");
            //Display(cr.fetchEmployees1());

            Console.Write("Enter the Salary : ");
            double Salary = double.Parse(Console.ReadLine());
            Console.WriteLine("******Modified Stored Procedure******");
            Display(cr.fetchEmployees2(Salary));
            

            Console.ReadLine();
        }
    }
}
