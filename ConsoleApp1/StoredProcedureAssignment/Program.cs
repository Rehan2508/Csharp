using AssignmentDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoredProcedureAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD crud = new CRUD();
            Console.Write("Enter the Id : ");
            int id = int.Parse(Console.ReadLine());
            crud.CheckEmployeeInDB(id);

            Console.ReadLine();
        }
    }
}
