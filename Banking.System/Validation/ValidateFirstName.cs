﻿using System;
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
                Console.WriteLine("Please your firstname starting with uppercase");
                string FirstName = Console.ReadLine();

                if (!char.IsUpper(FirstName[0]))
                {
                    Console.WriteLine("Please enter your name begin with uppercase");
                }

                if (char.IsDigit(FirstName[0]))
                {
                    Console.WriteLine("Your name must not begin with a digit");
                    continue;
                }
                return FirstName;
            }
        }
    }
}
