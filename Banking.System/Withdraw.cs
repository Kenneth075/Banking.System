﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Withdraw:CustomerRegistration
    {
        public int Amount;
        public Withdraw()
        {
        }

        public void withdrawFunction()
        {
            Console.Clear();
            Console.WriteLine("WITHDRAW FUNDS");
            Console.WriteLine();
            Console.Write("Enter amount to withdraw: ");
            Amount = Convert.ToInt32(Console.ReadLine());

            foreach (var item in customers)
            {
                if (item.Balance!= null)
                {
                    item.Balance -= Amount;
                    Console.WriteLine($"Your new balance is: {item.Balance}");
                    Console.WriteLine();
                    Console.WriteLine("SEE YOUR UPDATES BELOW");


                    Console.WriteLine($"FirstName: {item.FirstName}");
                    Console.WriteLine($"LastName: {item.LastName}");
                    Console.WriteLine($"Fullname: {item.FirstName} {item.LastName}");
                    Console.WriteLine($"Email: {item.Email}");
                    Console.WriteLine($"AccountNumber: {item.AccountNumber}");
                    Console.WriteLine($"AccountType: {item.AccountType}");
                    Console.WriteLine($"Balance: {item.Balance}");
                }


            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Eneter 1 to go back to BankMenu");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var menu = new BankMenu();
                menu.BankMenuFunction();
            }
        }
    }
}

    

