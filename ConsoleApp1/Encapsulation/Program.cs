using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program

    
    {
        static long[] numbers;
        static long Calculate(int n)
        {
            if (0 == numbers[n])
            {
                numbers[n] = Calculate(n - 1) + Calculate(n - 2);
            }
            return numbers[n];
        }
        static void Main(string[] args)
        {
            /*Console.Write("Enter the number : ");
            int num = int.Parse(Console.ReadLine());
            Example ex = new Example(num);
            int[] arr = ex.PowerTo();
            for(int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);

            string firstName = "John";
            string lastName = "Doe";
            string name = firstName + lastName;
            Console.WriteLine(name);
            string name1 = string.Concat(firstName, lastName);
            Console.WriteLine(name1);*/



            int celsius, faren;
            Console.WriteLine("Enter the Temperature in Celsius(C) : ");
            celsius = int.Parse(Console.ReadLine());
            faren = (celsius * 9) / 4 + 32;
            Console.WriteLine("Temperature in Farenheit is (F) : " + faren);

            

            Console.ReadLine();
        }
    }
}
