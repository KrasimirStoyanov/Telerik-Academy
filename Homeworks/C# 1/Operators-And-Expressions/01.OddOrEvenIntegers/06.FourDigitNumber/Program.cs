using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.*/

namespace _06.FourDigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a four-digit number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            

            int a = (number / 1000)%10;
            int b = (number / 100)%10;
            int c = (number / 10)%10;
            int d = number % 10;

            if ((number > 10000) || (a == 0))
            {
                Console.WriteLine("Your number is out of bounds");
            }
            else
            {
                Console.WriteLine("The sum of the number is: " + (a + b + c + d));
                Console.WriteLine("The number in reversed order is: " + d + c + b + a);
                Console.WriteLine("The number with last digit first is: " + d + a + b + c);
                Console.WriteLine("The number with exchanged 2nd and 3rd digit is: " + a + c + b + d);
            }
        }
    }
}
