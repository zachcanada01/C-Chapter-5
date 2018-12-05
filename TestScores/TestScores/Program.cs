using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int testScore;
            string testString;
            int max = 100;
            int min = 0;
            int total = 0;
            int count = 0;


            do
            {

                WriteLine("Please enter your test score.");
                testString = ReadLine();
                testScore = Convert.ToInt32(testString);


                if (testScore <= max && testScore >= min)
                {
                    count++;

                    total = total + testScore;

                }

                else if (testScore == 999)
                {

                    WriteLine("The average is " + total / count);
                    WriteLine("The total time entered was " + count);
                }
            } while(testScore != 999);



        }
    }
}
