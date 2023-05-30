﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class BankMenu
    {
        public string choice;

        public void BankMenuFunction()
        {
            Console.WriteLine();
            Console.WriteLine("|-------------------------|");
            Console.WriteLine("|         BANK MENU       |");
            Console.WriteLine("|-------------------------|");
            Console.WriteLine();
            Console.WriteLine("Please choose an option:");
            Console.WriteLine();
            Console.WriteLine("1. CREATE MORE ACCOUNT");
            Console.WriteLine();
            Console.WriteLine("2. CHECK ACCOUNT BALANCE");
            Console.WriteLine();
            Console.WriteLine("3. MAKE A DEPOSIT");
            Console.WriteLine();
            Console.WriteLine("4. MAKE A WITHDRAWAL");
            Console.WriteLine();
            Console.WriteLine("5. MAKE A TRANSFER");
            Console.WriteLine();
            Console.WriteLine("6. GET STATEMENT OF ACCOUNTS");
            Console.WriteLine();
            Console.WriteLine("7. LOGOUT");
            Console.WriteLine();
            Console.Write("Enter your choice (1-7): ");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                    Console.Write("YOU SELECTED CREATE MORE ACCOUNT.");
                    var reg = new CustomerRegistration();
                    reg.CustomerFunction();

                    break;
                case "2":
                    Console.Write("YOU SELECTED CHECK ACCOUNT BALANCE.");


                    break;
                case "3":
                    Console.Write("YOU SELCECTED MAKE A DEPOSIT.");
                    var deposit = new Deposit();
                    deposit.depositFunction();

                    break;
                case "4":
                    Console.Write("YOU SELECTED MAKE A WITHDRAWAL.");
                    var withdrawal = new Withdraw();
                    withdrawal.withdrawFunction();

                    break;
                case "5":
                    Console.Write("YOU SELECTED MAKE A TRANSFER.");

                    break;
                case "6":
                    Console.Write("YOU SELECTED GET STATEMENT OF ACCOUNT.");

                    break;
                case "7":
                    Console.Write("LOGOUT SELECTED.");

                    break;
                default:
                    Console.Write("Invalid choice.");
                    break;

            }
        }
    }
}
