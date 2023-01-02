using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //POCI : plain old classic runtime object

            Patient patient = new Patient();
            patient.Id = 101;
            patient.Name = "ramesh";
            patient.temp = 102.05F;
            Console.WriteLine($"Hi {patient.Name}, your id is {patient.Id} and temp is {patient.temp}");

            List<Patient> list = new List<Patient>();
            Patient pat = new Patient();
            pat.Id = 102;
            pat.Name = "Gamesh";
            pat.temp = 99;

            list.Add(pat);
            list.Add(patient);

            foreach (Patient p in list)
            {
                Console.WriteLine($"{p.Id} | {p.Name} | {p.temp}");
            }

            Console.ReadLine();
        }
    }
}
