﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bank_Application.Validation
{
    internal class ValidatePassword
    {
        public string ValidPasswordCollector()
        {
            string passwordPattern = @"^(?=.*[@#$%^&!])(?=.*[a-zA-Z0-9]).{6,}$";

            Console.WriteLine("Enter Password " +
                "\n Password should be minimum of 6 characters that include alphanumeric and at least one special characters");
            string password = Console.ReadLine()!;

            while (!Regex.IsMatch(password, passwordPattern))
            {
                Console.WriteLine("Please enter a valid password! Try again.");
                Console.WriteLine("Password should be minimum of 6 characters that include alphanumeric and at least one special characters(@, #, $, %, ^, &, !)");
                password = Console.ReadLine()!;
            }

            return password;
            
        }
    }
}
