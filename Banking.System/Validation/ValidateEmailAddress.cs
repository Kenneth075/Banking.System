using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank_Application.Validation
{
    internal class ValidateEmailAddress
    {
        public bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        public string EmailAddressCollector()
        {
            while (true)
            {
                Console.Write("Please enter your email address: ");
                string email = Console.ReadLine();

                if (!IsValidEmail(email))
                {
                    Console.WriteLine("Invalid email, please enter a vaild email");
                    continue;
                }
                return email;
            }
        }
       
    }
}
