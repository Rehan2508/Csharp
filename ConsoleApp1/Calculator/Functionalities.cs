using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface Functionalities
    {
        double Add(double x, double y);
        double Substract(double x, double y);
        double Multiplication(double x, double y);
        double Divide(double x, double y);
        double Modulus(double x, double y);
        double Square(double x);
        double SqRoot(double x);
        double PowerFunction(double x, double p);
    }
}
