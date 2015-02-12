using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.
namespace _11.ExtractBit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int moveRight = number >> 3;
            int mask = 1;
            int result = moveRight & mask;

            Console.WriteLine("The binary representation of your int is: " + Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("Therefore the bit at the third position is: " + result);
        }
    }
}
