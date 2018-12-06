using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 11;
            int againL = 1;
            int againH = 11;
            int count = 0;
            string guessString;
            int guess = 9000;
            string result = null;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);
            while (guess != randomNumber)
            {
                Write("Choose a number bewtween 1-10 >>>");
                guessString = ReadLine();
                guess = Convert.ToInt32(guessString);

                if (guess < 10 && guess > 1)
                {
                    if (randomNumber == guess)
                    {
                        result = "Congratulations on the guess of " + randomNumber;
                    }
                    else if (guess < randomNumber)
                    {
                        result = "You guessed " + guess + " to low";
                        if (guess <= againL)
                        {
                            result = "What? " + guess + " Still to low";
                        }
                        againL = guess;
                    }

                }
                else if (guess > randomNumber)
                {
                    result = "You guessed " + guess + " to high";
                    if (guess >= againH)
                    {
                        result = "What?" + guess + "Still to high";
                    }
                    againH = guess;
                }
                else if (guess < min || guess > max)
                {
                    result = "Out of bounds";
                }
                DisplayString(result);
                count++;
            }
            result = "You guessed " + guess + " in " + count + " tries.";
            DisplayString(result);
        }
        static void DisplayString(string result)
        {
            WriteLine(result);
        }
    }
}
