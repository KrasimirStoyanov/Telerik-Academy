using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
//at the position p from the binary representation of n while preserving all other bits in n.
namespace _14.ModifyABitAtGivenPosition
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

            Console.Write("Please enter a value which is 0 or 1 : ");
            string input3 = Console.ReadLine();
            int val = int.Parse(input2);

            int mask = 1;
            int result;

            if (val == 1)
            {
                mask = mask << index;
                result = number | mask;
            }
            else
            {
                mask = ~(mask << index);
                result = number & mask;
            }

            Console.WriteLine("The binary representation of the number is: " + Convert.ToString(number, 2).PadLeft(16, '0'));
            Console.WriteLine("The binary representation of the result is: {0}", Convert.ToString(result, 2).PadLeft(16, '0'));
            Console.WriteLine("Therefore the bit at the index position is: " + result);
             
        }
    }
}
