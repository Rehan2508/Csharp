using MyGenerics.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyGenerics
{
    internal class Program
    {

        public void M<T>(T x, int y)
        {

        }
        static void Main(string[] args)
        {
            MyClass<string> obj = new MyClass<string>();
            obj.y = "Hello";
            obj.MyMethod("Hi");

            Program program = new Program();
            program.M(5,6);

            //we can pass upto 7 parameters in tuples
            Tuple<int, int, string, float> x = new Tuple<int, int, string, float>(5,6,"rehan",10F);
            Console.WriteLine(x.Item3);

            InBuiltGenerics inBuiltGenerics = new InBuiltGenerics();
            inBuiltGenerics.MyDictionary();

            //Anonomous type : used when we dont want to declare the model
            var doctor = new
            {
                id = 101,
                name = "Shyam"
            };

            

            Console.ReadLine();
        }

        //read dynamiv vs object
        public static void M1(object o) 
        {
            
        }

        public static void M2(dynamic d)   //dynamic can represent any object
        {
            Patient p = new Patient()
            {
                Id = 101,
                name = "rehan"
            };

            Pharmacy p1 = new Pharmacy()
            {
                id = 1,
                name = "Asprin",
                expiry = DateTime.Now
            };
            dynamic dyn = new ExpandoObject();
            dyn.p = p;
            dyn.p1 = p1;

            dynamic dyn2 = new { patient = p };
            //Pharmacy p2 = dyn2.GetType().GetProperty("patient")
        }

        public static void M3(Patient o)
        {

        }

        //i'll decide the T type when i instanciate the class
        public class MyClass<T>
        {
            private int x;
            public T y;

            public void MyMethod(T x)
            {
                if (typeof(T) == typeof(int))
                    Console.WriteLine("Send SMS");
                else if (typeof(T) == typeof(string))
                    Console.WriteLine("Send Email");
            }

            public T MyMethod1(T n)
            {
                //T z = n;
                //return z;

                object y = n;
                return (T)y;
            }
        }
    }
}
