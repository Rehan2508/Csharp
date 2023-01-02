using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculations : Functionalities
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }

        public double Modulus(double x, double y)
        {
            return x % y;
        }

        public double Multiplication(double x, double y)
        {
            return x * y;
        }

        public double PowerFunction(double x, double p)
        {
            return Math.Pow(x,p);
        }

        public double SqRoot(double x)
        {
            return Math.Sqrt(x);
        }

        public double Square(double x)
        {
            return x * x;
        }

        public double Substract(double x, double y)
        {
            return x - y;
        }
    }
}
