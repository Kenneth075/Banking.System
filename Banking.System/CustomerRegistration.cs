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
            var AccountBalance = new Balance();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Wellcome to Kennis Bank the people's bank");
                Console.WriteLine();
                Console.WriteLine("Please enter your details below to register");
                Console.WriteLine();

                var firstName = ValidatefirstName.FirstNameCollector();
                Console.WriteLine();
                var lastName = ValidatelastName.LastNameCollector();
                Console.WriteLine();
                var emailAddress = Validateemail.EmailAddressCollector();
                Console.WriteLine();
                var password = Validatepassword.ValidPasswordCollector();
                Console.WriteLine();
                var accountNumber = OpenAccount.AccountNumber();
                Console.WriteLine();
                var myAccountType = OpenAccount.AccountType();
                Console.WriteLine();
                var myBalance = AccountBalance.balancefunction();

            
                Customers customer = new Customers(firstName, lastName, emailAddress, password, accountNumber, myAccountType, myBalance);
                customers.Add(customer);

                Console.WriteLine("Customer added successfully");
                Console.WriteLine("Please do you want to continue (Yes/No)");
                string choice= Console.ReadLine()!;

                if(choice.Equals("No", StringComparison.OrdinalIgnoreCase))
                    exit = true;
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("|-----------------------|");
                Console.WriteLine("|  YOUR ACCOUNT DETAILS |");
                Console.WriteLine("|-----------------------|");
                Console.WriteLine();

                foreach(var cust in customers)
                {
                    Console.WriteLine($"firstName:{cust.FirstName}");
                    Console.WriteLine($"lastName:{cust.LastName}");
                    Console.WriteLine($"fullName:{cust.FirstName}:{cust.LastName}");
                    Console.WriteLine($"emailAddres:{cust.Email}");
                    Console.WriteLine($"accountNumber:{cust.AccountNumber}");
                    Console.WriteLine($"accontType:{cust.AccountType}");
                    Console.WriteLine($"accountBalance:{cust.Balance}");
                    
                }

                Console.WriteLine("Your registration is successfull");
                
                promptForLogin();
                
            }   
            
        }
        private void promptForLogin()
        {
            Console.WriteLine("Would you like to login? Yes or No");
            string loginChoice= Console.ReadLine()!;

            if (loginChoice.Equals("No", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thank you for banking with us");
            }
            else if(loginChoice.Equals("Yes", StringComparison.OrdinalIgnoreCase))
            {
                string loginInput;
                do
                {
                    Console.WriteLine("Please enter '3' to log in:");
                    loginInput = Console.ReadLine()!;
                } while (loginInput != "3");
                var login = new Login();
                login.LoginFunction();
            }

            
        }
        
            
           

        











    }
}
