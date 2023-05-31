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
                allprint += $"| {acc.FirstName,-15}| {acc.LastName,-15}| {acc.AccountNumber,15}|  {acc.AccountType} | {acc.Balance,-16}|\n";
            }
            Console.WriteLine("|--------------------|------------------|--------------------|----------------------|");
            Console.WriteLine("|     FULLNAME       |  ACCOUNT NUMBER  |   ACCOUNT TYPE     |   ACCOUNT BALANCE    |");
            Console.WriteLine("|--------------------|------------------|--------------------|----------------------|");
            Console.WriteLine(allprint);
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
    }
            
            

}
    


