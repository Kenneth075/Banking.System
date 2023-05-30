﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class Deposit: CustomerRegistration
    {
        public int Amount { get; set; }


        public Deposit()
        {
        }

        public void depositFunction()
        {
            Console.Clear();
            Console.WriteLine("DEPOSIT FUNDS");
            Console.WriteLine();
            Console.Write("Enter amount to deposit:");
            Amount = Convert.ToInt32(Console.ReadLine());

            foreach (var item in customers)
            {
                if (item.balance != null)
                {
                    item.balance += Amount;
                    Console.WriteLine($"Your new balance is: {item.balance}");
                    Console.WriteLine();
                    Console.WriteLine("SEE YOUR UPDATES BELOW");


                    Console.WriteLine($"FirstName: {item.firstName}");
                    Console.WriteLine($"LastName: {item.lastName}");
                    Console.WriteLine($"Fullname: {item.firstName} {item.lastName}");
                    Console.WriteLine($"Email: {item.emailAddress}");
                    Console.WriteLine($"AccountNumber: {item.accountNumber}");
                    Console.WriteLine($"AccountType: {item.accountType}");
                    Console.WriteLine($"Balance: {item.balance}");
                }


            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Eneter 1 to go back to BankMenu");
            string choice = Console.ReadLine()!;
            if (choice == "1")
            {
                var menu = new BankMenu();
                menu.BankMenuFunction();
            }





        }
    }
}
    

