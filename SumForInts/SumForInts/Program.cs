using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SumForInts
{
    class Program
    {
        static void Main(string[] args)
        {
            int one;
            int two;
            int three;
            int four;
            int total;
            string oneString;
            string twoString;
            string threeString;
            string fourString;

            WriteLine("Please enter an integer");
            oneString = ReadLine();
            one = Convert.ToInt32(oneString);
            WriteLine("Enter another");
            twoString = ReadLine();
            two = Convert.ToInt32(twoString);
            WriteLine("Enter another");
            threeString = ReadLine();
            three = Convert.ToInt32(threeString);
            WriteLine("Enter another");
            fourString = ReadLine();
            four = Convert.ToInt32(fourString);

            total = one + two + three + four;

            WriteLine("The sum is " + total);
        }
    }
}
