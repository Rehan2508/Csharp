using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bike
    {
        public int id { get; set; }
        public int tyres { get; set; }  
        public float cc { get; set; }
        public string color { get; set; }
        public float fuelCapacity { get; set; }

        public virtual void Discount()
        {
            Console.WriteLine("parent : Discount");
        }
    }

    internal class Gixxer : Bike
    {
        public override void Discount()
        {
            Console.WriteLine("child, Gixxer : 10%");
        }
    }

    internal class Hornet : Bike
    {

    }
}
