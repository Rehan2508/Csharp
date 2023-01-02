using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Rehan", "00000001223", "current", 0);
            bank.DisplayDetails();
            bank.DepositAmount(500000000);
            bank.CheckBalanceAndWithdrawAmount();
            bank.DisplayDetails();

            Console.ReadLine();
        }
    }
}
