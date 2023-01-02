using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Models.Customer
{
    internal class Assignment1
    {
        public void CelsiusToFahrenheit()
        {
            Console.Write("Enter the temperature : ");
            double temp = double.Parse(Console.ReadLine());

            Console.WriteLine($"temperature in \"Fahrenheit\" is : {((temp * 9) / 5) + 32}");
        }
    }
}
