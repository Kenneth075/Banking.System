using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application.Accounts
{
    internal class SavingAccount
    {
        public long SavingsNumber()
        {
            Random random = new Random();
            var SavingsAccountNumber = random.Next(0000000001, 1999999999);
            return SavingsAccountNumber;
        }
    }
}
