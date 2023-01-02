using DoctorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoctorDetails doctorDetails = new DoctorDetails();

            List<Doctor> doctorList = doctorDetails.GetDoctor();
            foreach (Doctor doctor in doctorList)
            {
                Console.WriteLine($"{doctor.Id} | {doctor.Name} | {doctor.HospitalName} | {doctor.ContactNo}");
            }

            Console.ReadLine();
        }
    }
}
