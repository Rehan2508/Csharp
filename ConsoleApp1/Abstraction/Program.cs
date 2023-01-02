using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public interface IInvoicing
    {
        void Estimate(string customerId, string customerName);
        int Greeting(DateTime AnniversaryData);
    }

    public interface IBilling
    {
        void Estimate(string customerId, string customerName);
        int Greeting(DateTime AnniversaryData);
    }

    public class Child : IBilling, IInvoicing
    {
        //if we have explicitly declared the method with same signature of a interface then we can
        //leave one without defining explicitly.
        //if we are not explicitly declaring a method of interface inherited then we have to declare
        //the access specifier.
        public void Estimate(string customerId, string customerName)
        {
        
        }

        int IBilling.Greeting(DateTime AnniversaryData)
        {
            return 10;
        }

        //if we have explicitly declared the method of the inherited interface then we cant declare
        //the access specifier
        void IInvoicing.Estimate(string customerId, string customerName)
        {

        }

        int IInvoicing.Greeting(System.DateTime AnniversaryData)
        { 
            return 10; 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
