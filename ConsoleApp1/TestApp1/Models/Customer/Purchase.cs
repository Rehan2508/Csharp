using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Models.Customer
{
    internal class Area
    {
        private int radius;
        private int? length;
        private int? breadth;

        public Area(int radius, int? length, int? breadth)
        {
            this.radius = radius;
            this.length = length;
            this.breadth = breadth;
        }

        public void AreaMethod()
        {
            if (this.length == null || this.breadth == null)
                Console.WriteLine("Area of circle is : " + this.radius * this.radius * 3.14F);
            else
                Console.WriteLine("Area of rectangle is : " + this.length * this.breadth);
        }



        /*
        public void AreaMethod(int radius)
        {
            Console.WriteLine("Area of the circle is : " + radius * radius * 3.14F);
        }

        public void AreaMethod(int l, int b)
        {
           Console.WriteLine($"Area of the rectangle is : {l * b}");
        }
        */
    }

    internal class Purchase
    {
    }
}
