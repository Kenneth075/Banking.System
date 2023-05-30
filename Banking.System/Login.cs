using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Login: CustomerRegistration
    {
        string loginEmail;
        string loginpassword;

        public void LoginFunction()
        {
            Console.WriteLine();
            Console.WriteLine("|--------------|");
            Console.WriteLine("|   Login      |");
            Console.WriteLine("|--------------|");
            Console.WriteLine();

            Console.WriteLine("Enter your email address");
            loginEmail = Console.ReadLine();

            foreach(var items in customers)
            {
                if (loginEmail == items.emailAddress)
                {
                    Console.WriteLine("Enter your password");
                    loginpassword = Console.ReadLine();

                    if(loginpassword == items.password)
                    {
                        Console.Clear();
                        var bankmemu = new BankMenu();
                        bankmemu.BankMenuFunction();

                    }
                }
            }
        }
    }
}
