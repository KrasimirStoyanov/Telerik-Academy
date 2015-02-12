using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write an expression that checks if given positive integer number n 
// (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive
namespace _08.PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to check if it's prime: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            bool prime = false;

            if (number > 1 && number < 101)
            {
                if (number == 2 || number == 3 || number == 5 || number == 7)
                {
                    prime = true;
                }
                else if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0)
                {
                    prime = true;
                }
            }
            Console.WriteLine("It is " + prime + " that the number is prime");
        }
    }
}
