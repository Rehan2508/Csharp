using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void MyDelegate(int x);

    //Func, Action, Predicate
    internal class Program
    {
        public static void Square(int x)
        {
            Console.WriteLine(x * x);
        }

        public static void Cube(int x)
        {
            Console.WriteLine(x * x * x);
        }

        public static void Quad(int x)
        {
            Console.WriteLine(x * x * x * x);
        }

        public static int Square1(int x)
        {
            return x * x;
        }

        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public static bool Status(string status)
        {
            if (status == "Open")
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {

            //MyDelegate m = new MyDelegate(MyMethod);
            //m(10);

            //multicasting of delegates : run multiple method with one input
            //MyDelegate m = new MyDelegate(Square);
            //m += Cube;
            //m += Quad;
            //m.Invoke(10);

            //Action<int> mult = Square;
            //mult += Cube;
            //mult +=Quad;
            //mult.Invoke(10);

            Func<int, int> sq = Square1;
            int sqr = sq.Invoke(10);
            Console.WriteLine(sqr);

            Func<int, int, int, int> s = Sum;
            int sum = s.Invoke(10, 20, 30);
            Console.WriteLine(sum);

            Predicate<string> p = Status;
            bool check = p("Open");
            Console.WriteLine(check);

            Console.ReadLine();
        }
    }
}
