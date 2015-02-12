using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks if given integer is odd or even.
namespace _01.OddOrEvenIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            bool oddChecker = (number % 2)!=0;
            Console.WriteLine(oddChecker);
        }
    }
}
