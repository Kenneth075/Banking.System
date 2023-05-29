using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application.Validation
{
    internal class ValidateLastName
    {
        public string LastNameCollector()
        {
            while (true)
            {
                Console.WriteLine("Please your lasttname starting with an uppercase");
                string LastName = Console.ReadLine();

                if (!char.IsUpper(LastName[0]))
                {
                    Console.WriteLine("Please enter your name begin with uppercase");
                }

                if (char.IsDigit(LastName[0]))
                {
                    Console.WriteLine("Your name must not begin with a digit");
                    continue;
                }
                return LastName;
            }
        }
    }
}
