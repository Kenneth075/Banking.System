using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Customers
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string password;
        public string accountType;
        public int accountNumber;
        public int balance;
        private int myAccoutNumber;
        private string myAccountType;
        private int myBalance;

        public Customers(string firstName, string lastName, string emailAddress, string password, string accountType, int accountNumber, int balance)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.password = password;
            this.accountType = accountType;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public Customers(string firstName, string lastName, string emailAddress, string password, int myAccoutNumber, string myAccountType, int myBalance)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.password = password;
            this.myAccoutNumber = myAccoutNumber;
            this.myAccountType = myAccountType;
            this.myBalance = myBalance;
        }
    }

}
