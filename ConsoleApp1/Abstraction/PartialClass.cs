using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface Interface1
    {
        void Method();
        void Method1();
        void Method2();
        void Method3();
    }

    public partial class Child1 : Interface1
    {
       public void Method()
        {

        }
    }

    public partial class Child1
    {
        public void Method1() { }
    }

    public partial class Child1
    {
        public void Method2() { }
    }

    public partial class Child1
    {
        public void Method3() { }
    }
    internal class PartialClass
    {
    }
}
