using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Models.Customer
{
    internal class Power
    {
        private int x;
        private int square;
        private int cube;
        private int quad;

        public Power(int x) 
        { 
            this.square = x * x;
            this.cube = x * x * x;
            this.quad = x * x * x * x;
        }

        public Power(int x, out int square, out int cube, out int quad)
        {
            square = x * x;
            cube = x * x * x;
            quad = x * x * x * x;
        }

        public void Display()
        {
            Console.WriteLine($"Square of the number : {this.square}");
            Console.WriteLine($"Cube of the number : {this.cube}");
            Console.WriteLine($"Quadruple of the number : {this.quad}");
        }
    }
}
