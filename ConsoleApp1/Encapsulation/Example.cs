using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Example
    {
        private int x;

        public Example(int x)
        {
            this.x = x;
        }

        public int[] PowerTo()
        {
            int[] result = new int[3];
            result[0] = x * x;
            result[1] = x * x * x;
            result[2] = x * x * x * x;
            return result;
        }
    }
}
