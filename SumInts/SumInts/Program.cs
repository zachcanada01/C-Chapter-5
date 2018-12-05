using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput;
            string userInputString;
            int total;
            do
            {
                WriteLine("Enter an interger, enter 999 to stop.");
                userInputString = ReadLine();
                userInput = Convert.ToInt32(userInputString);
                total = userInput++;
                
                
            } while (userInput != 999);

          
            WriteLine("The sum is " + total);
            

          
        }
    }
}
