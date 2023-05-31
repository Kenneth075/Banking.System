using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Customers
    {
            public string FirstName;
            public string LastName;
            public string Email;
            public string Password;
            public int AccountNumber;
            public string AccountType;
            public int Balance;

            public Customers(string FirstName, string LastName, string Email, string Password, int AccountNumber, string AccountType, int Balance)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Email = Email;
                this.Password = Password;
                this.AccountNumber = AccountNumber;
                this.AccountType = AccountType;
                this.Balance = Balance;
            }
    }
       
}

