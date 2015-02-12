using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write an expression that extracts from given integer n the value of given bit at index p.
namespace _12.ExtractBitFromInteger
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
            Console.WriteLine("Therefore the bit at the index position is: " + result);
        }
    }
}
