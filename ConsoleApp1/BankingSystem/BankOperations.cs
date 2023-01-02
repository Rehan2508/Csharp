using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    internal interface BankOperations
    {
        void DepositAmount(int amount);
        void CheckBalanceAndWithdrawAmount();
        void DisplayDetails();
    }
}
