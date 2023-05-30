using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Application.Accounts;
using Bank_Application.Validation;

namespace Bank_Application
{
    internal class CustomerRegistration
    {
        public static List<Customers> customers = new List<Customers>();

        public void CustomerFunction()
        {
            var ValidatefirstName = new ValidateFirstName();
            var ValidatelastName = new ValidateLastName();
            var Validateemail = new ValidateEmailAddress();
            var Validatepassword = new ValidatePassword();
            var OpenAccount = new AccountChoice();
            var AccountType= new AccountChoice();
            var AccountBalance = new Balance();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("       WELLCOME            ");
                Console.WriteLine("Wellcome to \"Kennis Bank\" the people's bank");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Please kindly enter your details below to register");
                Console.WriteLine();

                var firstName = ValidatefirstName.FirstNameCollector();
                Console.WriteLine();
                var lastName = ValidatelastName.LastNameCollector();
                Console.WriteLine();
                var emailAddress = Validateemail.EmailAddressCollector();
                Console.WriteLine();
                var password = Validatepassword.ValidPasswordCollector();
                Console.WriteLine();
                var myAccoutNumber = OpenAccount.AccountNumber();
                Console.WriteLine();
                var myAccountType = AccountType.AccountType();
                Console.WriteLine();
                var myBalance = AccountBalance.balancefunction();

                Customers customer= new Customers(firstName, lastName, emailAddress,password, myAccoutNumber,myAccountType,myBalance);
                customers.Add(customer);

                Console.WriteLine("Customer added successfully");
                Console.WriteLine("Please do you want to continue (Yes/No");
                string choice= Console.ReadLine();
            }
        }











    }
}
