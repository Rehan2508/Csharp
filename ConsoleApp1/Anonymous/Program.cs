using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous
{
    internal class Program
    {
        public delegate void petname(String name);
        static void Main(string[] args)
        {

            string p = "Dog";
            petname pan = delegate (string pname)
            {
                Console.WriteLine($"The animal is {p}");
                Console.WriteLine($"The animal is {pname}");
            };
            pan("Cat");

            Console.ReadLine();
        }
    }
}
