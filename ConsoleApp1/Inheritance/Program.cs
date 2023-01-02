using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ParentClass
    {
        public void Discount()
        {
            Console.WriteLine("discount parent");
        }
    }

    internal class Child1 : ParentClass
    {
        public new void Discount()
        {
            Console.WriteLine("discount child1");
        }
    }

    internal class Child2 : ParentClass
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Gixxer gixxer = new Gixxer();   
            gixxer.Discount();

            Hornet hornet = new Hornet();
            hornet.Discount();

            //parent class reference variable to create a child class object
            Bike bike = new Gixxer();
            bike.Discount();
            bike = new Hornet();
            bike.Discount();

            //error
            //Gixxer gixxer1 = (Gixxer)(new Bike());
            //gixxer1.Discount();

            //error
            //Hornet hornet1 = (Hornet)new Bike();
            //hornet1.Discount(); 

            Console.WriteLine("array of obj implimentation :");
            Bike[] b = new Bike[2];
            b[0] = new Gixxer();
            b[1] = new Hornet();
            b[0].Discount();
            b[1].Discount();

            /*
            Console.Write("Enter the gst : ");
            float gst = float.Parse(Console.ReadLine());

            Console.Write("Enter the discount : ");
            float discount = float.Parse(Console.ReadLine());

            Child child = new Child(gst,discount);
            Console.Write("Enter the cost price of servicing : ");
            float cost = float.Parse(Console.ReadLine());
            Console.WriteLine("Total Cost : " + child.TotalCost(cost));
            */

            /*
            Child1 child1 = new Child1();
            child1.Discount();

            Child2 child2 = new Child2();
            child2.Discount();

            ParentClass parent = new Child1();
            parent.Discount();
            */

            Console.ReadLine();
        }
    }
}
