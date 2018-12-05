using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnterLowerCaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            string userString;
            
            do 
            {
                WriteLine("Please enter a lower case letter");
                userString = ReadLine();

                if (userString.Any(char.IsLower))
                {
                    WriteLine("OK");
                }
                else if (userString.Any(char.IsUpper))
                {
                    WriteLine("Error");
                }
                
            } while (userString != "!");


        }
    }
}
