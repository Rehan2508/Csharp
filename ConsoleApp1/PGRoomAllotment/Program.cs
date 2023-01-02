using PGRoomAllotmentDAL;
using PGRoomAllotmentDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGRoomAllotment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRUD crud = new CRUD();
            crud.GetTable();

            Rooms room = new Rooms();
            Console.Write("Enter the name : ");
            room.name = Console.ReadLine();
            Console.Write("Enter the Contact Number :");
            room.contactNo = Console.ReadLine();
            Console.Write("Enter the Home City : ");
            room.homeCity = Console.ReadLine();
            Console.Write("Enter the Home State : ");
            room.homeState = Console.ReadLine();
            Console.Write("Enter the Rent : ");
            room.rent = double.Parse(Console.ReadLine());
            Console.Write("Enter the Deposite : ");
            room.deposite = double.Parse(Console.ReadLine());
            Console.Write("Enter the Company Name : ");
            room.companyName = Console.ReadLine();

            Console.WriteLine(crud.InsertIntoTable(room))
                ;

            crud.GetTable();
        }
    }
}
