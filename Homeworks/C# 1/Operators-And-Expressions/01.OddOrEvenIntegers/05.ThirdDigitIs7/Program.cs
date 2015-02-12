using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write an expression that checks for given integer if its third digit from right-to-left is 7.
namespace _05.ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to check if its third digit is 7: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            bool checker = (number % 1000) / 100 == 7;
            Console.WriteLine(checker);
        }
    }
}
