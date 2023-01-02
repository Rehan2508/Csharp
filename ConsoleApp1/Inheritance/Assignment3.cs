using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Parent
    {
        private float gst;

        public Parent(float gst)
        {
            this.gst = gst;
        }

        public float GST(float cost)
        {
            return (cost * this.gst) / 100;
        }
    }

    internal class Child : Parent
    {
        private float discount;

        public Child(float gst,float discount) : base(gst)
        {
            this.discount = discount;
        }

        public float Discount(float cost)
        {
            return (cost * this.discount) / 100;
        }

        public float TotalCost(float mrp)
        {
            float priceAfterDiscount = (mrp - this.Discount(mrp));
            float totalCost = priceAfterDiscount + base.GST(priceAfterDiscount);
            return totalCost;
        }
    }

    internal class Assignment3
    {
        /*
        public static void main(String[]args)
        {
            Child child = new Child();
            Console.Write("Enter the cost price of servicing : ");
            float cost = float.Parse(Console.ReadLine());
            Console.WriteLine("Total Cost : " + child.TotalCost(cost));
        }
        */
    }
}
