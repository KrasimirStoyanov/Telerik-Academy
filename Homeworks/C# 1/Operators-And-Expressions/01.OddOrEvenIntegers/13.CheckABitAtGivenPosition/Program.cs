using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.
namespace _13.CheckABitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            Console.Write("Please enter an index: ");
            string input2 = Console.ReadLine();
            int index = int.Parse(input2);

            int moveRight = number >> index;
            int mask = 1;
            int result = moveRight & mask;

            Console.WriteLine("The binary representation of your int is: " + Convert.ToString(number, 2).PadLeft(16, '0'));
            
            if (result == 1)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
