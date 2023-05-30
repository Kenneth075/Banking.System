using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application.Accounts
{
    internal class AccountChoice
    {
        public string choice;
        public string Accounttype;

        public int AccountNumber()
        {
            Console.WriteLine("Enter 1 to create a savings account or 2 to create a current account");
            choice = Console.ReadLine();

            Random random = new Random();
            int accountNumber;

            if(choice == "1")
            {
                accountNumber = random.Next(1000000000,1999999999);
            }
            else if(choice == "2")
            {
                accountNumber = random.Next(1000000000, 1999999999);
            }
            else
            {
                throw new ArgumentException("Invalid choice. Please enter either 1 or 2");
            }
            return accountNumber;
        }

        public string AccountType()
        {
            if(choice == "1")
            {
                return "Savings Account";
            }
            else if( choice == "2")
            {
                return "Current Account";
            }
            else
            {
                throw new ArgumentException("Invalid Choice, Please enter a valid account number");
            }
            

        }
        
    }
}
