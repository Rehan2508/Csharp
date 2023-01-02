using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Bank : BankOperations
    {
        private string name;
        private string accno;
        private string type;
        private long balance;

        public Bank(string name, string accno, string type, long balance)
        {
            this.name = name;
            this.accno = accno;
            this.type = type;
            this.balance = balance;
        }

        public void DepositAmount(int amount)
        {
            this.balance += amount;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Name : {this.name}");
            Console.WriteLine($"Balance : {this.balance}");
        }

        public void CheckBalanceAndWithdrawAmount()
        {
            this.DisplayDetails();
            Console.Write("Press 1 to \"withdraw\" and 2 to \"exit\" : ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    {
                        Console.Write("Enter the amount to be withdrawn : ");
                        int a = int.Parse(Console.ReadLine());
                        if (this.balance < a)
                            Console.WriteLine("insufficent balance");
                        else
                        {
                            this.balance -= a;
                            Console.WriteLine("amount withdrawn");
                        }
                        break;
                    }
                 case 2:
                    {
                        Console.WriteLine("Thank You");
                        break;
                    }
                 default:
                    {
                        Console.WriteLine("Wrong Option : try again");
                        break;
                    }
            }
        }
    }
}
