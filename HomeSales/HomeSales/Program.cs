using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            double danielleTotal = 0;
            double edwardTotal = 0;
            double francisTotal = 0;
            string userInput;
            int userSale;
            string userString;
            int count = 0;
          
            do
            {
                WriteLine("Please enter your first name initial.");
                userInput = ReadLine();
             if (userInput == "d")
                {
                    WriteLine("Valid");
                    WriteLine("Danielle please enter the amount sold, enter z when done.");
                    userString = ReadLine();
                    userSale = Convert.ToInt32(userString);

                    count++;

                    danielleTotal = danielleTotal + userSale;
                }
                else if (userInput == "e")
                {
                    WriteLine("Valid");
                    WriteLine("Edward please enter the amount sold, enter z when done.");
                    userString = ReadLine();
                    userSale = Convert.ToInt32(userString);

                    count++;

                    edwardTotal = edwardTotal + userSale;
                }
                else if (userInput == "f")
                {
                    WriteLine("Valid");
                    WriteLine("Francis please enter the amount sold, enter z when done.");
                    userString = ReadLine();
                    userSale = Convert.ToInt32(userString);

                    count++;

                    francisTotal = francisTotal + userSale;
                }


                else {
                    WriteLine("Invalid");
                }
                
                
            } while(userInput != "z");

            WriteLine("Danielle sold " + danielleTotal + " houses.");
            WriteLine("Edward sold " + edwardTotal + " house.");
            WriteLine("Francis sold " + francisTotal + " houses.");
        }
    }
}
