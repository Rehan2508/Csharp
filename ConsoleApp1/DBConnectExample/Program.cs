using DBConnectExample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectExample
{
    internal class Program
    {
        public static void Display()
        {
            HospitalDetails hospitalDetails = new HospitalDetails();
            List<Patient> ptlist = hospitalDetails.GetPatient();
            foreach (Patient pt in ptlist)
            {
                Console.WriteLine($"{pt.id} | {pt.name} | {pt.ailment}");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Display();
            Console.WriteLine();
            HospitalDetails hospitalDetails1 = new HospitalDetails();

            //insert
            Console.WriteLine("******INSERT******");
            Patient patient = new Patient();
            Console.Write("Enter the patient id : ");
            patient.id = int.Parse(Console.ReadLine());
            Console.Write("Enter the patient name : ");
            patient.name = Console.ReadLine();
            Console.Write("Enter the ailment : ");
            patient.ailment = Console.ReadLine();

            string message = hospitalDetails1.InsertNewPatient(patient);
            Console.WriteLine(message);
            Display();

            //update
            Console.WriteLine("******UPDATE******");
            Patient patient2 = new Patient();
            Console.Write("Enter the patient id : ");
            patient2.id = int.Parse(Console.ReadLine());
            Console.Write("Enter the name : ");
            patient2.name = Console.ReadLine();
            Console.WriteLine(hospitalDetails1.UpdatePateint(patient2));
            Display();

            //delete
            Console.WriteLine("******DELETE******");
            Console.Write("Enter the Patient to be deleted : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(hospitalDetails1.DeletePatient(id));
            Display();

            Console.ReadLine();
        }
    }
}
