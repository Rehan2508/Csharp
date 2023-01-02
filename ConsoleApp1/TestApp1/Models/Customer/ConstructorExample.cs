using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1.Models.Customer
{
    internal class ConstructorExample
    {
        private int x;
        private int y;

        public ConstructorExample(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public ConstructorExample(int x = 100)
        {
            Console.WriteLine(x);
            this.x = x;
            Console.WriteLine(y);
        }
    }
}
