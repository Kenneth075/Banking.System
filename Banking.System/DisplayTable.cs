using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application
{
    internal class DisplayTable
    {
        public void DisplayAllTable()
        {
            string allprint = "";
            foreach(Customers acc in CustomerRegistration.customers)
            {
                allprint += $" | {acc.FirstName,-13} | {acc.LastName,-14}| {acc.AccountNumber,-18}|  {acc.AccountType,-18} | {acc.Balance,-16}|\n";
            }
            Console.WriteLine();
            Console.WriteLine("|----------------|---------------|------------------|--------------------|----------------------|");
            Console.WriteLine("|    FIRSTNAME   |   LASTNAME    |  ACCOUNT NUMBER  |   ACCOUNT TYPE     |   ACCOUNT BALANCE    |");
            Console.WriteLine("|----------------|---------------|------------------|--------------------|----------------------|");
            Console.WriteLine(allprint);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                var menu = new BankMenu();
                menu.BankMenuFunction();
            }
        }
    }
            
            

}
    


