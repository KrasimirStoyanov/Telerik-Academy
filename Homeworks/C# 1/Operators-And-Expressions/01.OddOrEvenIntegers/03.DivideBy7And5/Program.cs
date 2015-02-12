using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a Boolean expression that checks for given integer 
//if it can be divided (without remainder) by 7 and 5 at the same time.
namespace _03.DivideBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to check if it's divisible by 5 and 7: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            bool boolChecker = ((number % 5 == 0) && (number % 7) == 0);
            Console.WriteLine("It is: "+boolChecker+" that the number is divisible by 5 and 7");
        }
    }
}
