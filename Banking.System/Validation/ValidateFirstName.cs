using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application.Validation
{
    internal class ValidateFirstName
    {
        public string FirstNameCollector()
        {
            while (true)
            {
                Console.WriteLine("Please enter your firstname, begining with an uppercase: ");
                string FirstName = Console.ReadLine();

                if (!char.IsUpper(FirstName[0]))
                {
                   Console.WriteLine("Please enter your firstname begining with an uppercase: ");
                }

                if (char.IsDigit(FirstName[0]))
                {
                    Console.WriteLine("Your name can not begin with a digit");
                    continue;
                }
                return FirstName;
            }
        }
    }
}
