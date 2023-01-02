using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class MyAbstract
    {
        public abstract void M1();
        void M2() { }
    }

    public class MyChildClass : MyAbstract
    {
        public override void M1()
        {
            
        }
    }
    internal class AbstractClass
    {
    }
}
