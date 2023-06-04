using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Application.Validation
{
    public class ValidateFirstName
    {
        public string FirstNameCollector()
        {
            while (true)
            {
                Console.Write("Please enter your firstname, begining with an uppercase: ");
                string FirstName = Console.ReadLine()!;

                if (!char.IsUpper(FirstName[0]))
                {
                   Console.WriteLine("Error. begin with an uppercase: ");
                    continue;
                }
                return FirstName;

                
            }
            
            
        }
        
    }
}
