using MyGenerics.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyGenerics
{
    internal class InBuiltGenerics
    {
        public void myStack()
        {
            //Push, Pop, Peek
            Stack<int> marks = new Stack<int>();
            marks.Push(100);
            marks.Push(99);
            marks.Push(98);

        }

        public void MyQueue()
        {
            //Enqueue, Dequeue, Peek
            Queue<string> countries = new Queue<string>();
            countries.Enqueue("India");
            countries.Enqueue("Japan");
            countries.Enqueue("USA");
        }

        public void MyList()
        {
            List<string> books = new List<string>();
            books.Add("Pride and Prejudice");
            books.Add("Rich Dad Poor Dad");
        }

        public void MyDictionary()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "Ram");
            dic.Add(2, "Shyam");
            foreach (KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine(kvp.Key + " | " + kvp.Value);
            }

            Pharmacy p1 = new Pharmacy();
            p1.id = 101;
            p1.name = "Aspirin";
            p1.expiry = DateTime.Now.AddYears(2);

            Pharmacy p2 = new Pharmacy()
            {
                id = 102,
                name = "Dolo",
                expiry = DateTime.Now.AddMonths(3)
            };

            List<Pharmacy> pList = new List<Pharmacy>();
            Dictionary<int, Pharmacy> dic2 = new Dictionary<int, Pharmacy>();
            dic2.Add(p1.id,p1);
            dic2.Add(p2.id, p2);
            foreach (KeyValuePair <int, Pharmacy> kvp in dic2)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value.name} | {kvp.Value.expiry}");
            }
        }
    }
}
