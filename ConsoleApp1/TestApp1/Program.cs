using ConsoleApp2;
using a = ProjA;
using b = ProjB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TestApp1.Models.Customer;

namespace TestApp1
{
    internal class NamedMethod
    {
        public int x;
        public string y;

        public NamedMethod(int x, string y)
        {
            this.x = x;
            this.y = y;
        }

        public void Display(int a, string b)
        {
            Console.WriteLine($"x : {this.x}, y : {this.y}, a : {a}, b : {b}");
        }
    }

    internal class Program
    {
        /*
        public static void Mymethod(int x, ref int y)
        {
            x += 5;
            y += 5;
        }
        */

        public static void MyMethod(params string[] c)
        {
            foreach(string str in c)
            {
                Console.WriteLine(str);
            }
        }
        public static void Main(string[] args)
        { 
            //ProjA.SampleClass sampleClass1 = new ProjA.SampleClass();
            //sampleClass1.M1();

            //ProjB.SampleClass sampleClass2 = new ProjB.SampleClass();

            a.SampleClass sampleClass = new a.SampleClass();
            b.SampleClass sampleClass1 = new b.SampleClass();

            /*
            Assignment1 a1 = new Assignment1();
            a1.CelsiusToFahrenheit();

            Console.Write("Enter the \"Cost Price\" : ");
            double costPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the \"Sales Price\" : ");
            double salesPrice = double.Parse(Console.ReadLine());

            Assignment2 a2 = new Assignment2(salesPrice : salesPrice,costPrice : costPrice);
            a2.CalculateProfitORLoss();
            a2.Display();

            */

            //ConstructorExample example = new ConstructorExample(2,3);
            //ConstructorExample example2 = new ConstructorExample();

            //NamedMethod n = new NamedMethod(y : "Rehan", x : 10);
            //n.Display(b : "Dilkash", a : 10 );


            //Area a = new Area();
            //a.AreaMethod(10,20);
            //Area a = new Area(5,10,2);
            //a.AreaMethod();

            /*
            Console.WriteLine("**** first method ****");
            Power p = new Power(5);
            p.Display();

            int square;
            int cube;
            int quad;

            Console.WriteLine("**** second method ****");
            Power p1 = new Power(5, out square, out  cube, out quad);
            Console.WriteLine($"Square of the number : {square}");
            Console.WriteLine($"Cube of the number : {cube}");
            Console.WriteLine($"Quadruple of the number : {quad}");
            */

            /*
            string[] countries = { "India", "Japan", "USA" };
            MyMethod(countries);
            */

            /*
            int x = 10;
            int y = 10;
            Mymethod(x, ref y);
            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);
            */

            /*
            Multiplier multiples =  new Multiplier();
            int x = 5;

            Console.WriteLine("*** first way ***");
            Console.WriteLine("square " + multiples.Square(x));
            Console.WriteLine("cube  : " + multiples.Cube(x));
            Console.WriteLine("quad :" + multiples.Quad(x));

            Console.WriteLine("*** second way ***");
            int []arr = multiples.MulOperations(x);
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("square : " + arr[i]);
            }

            int square, cube, quad;
            multiples.calculate(x,out square,out cube,out quad);
            Console.WriteLine("*** thid way ***");
            Console.WriteLine("square " + square);
            Console.WriteLine("cube  : " + cube);
            Console.WriteLine("quad :" + quad);
            */

            Console.ReadLine();
        }
    }
}


namespace ProjA
{
    public class SampleClass
    {
        public void M1() { }
    }
}

namespace ProjB
{
    public class SampleClass
    {
        public void M1() { }
    }
}