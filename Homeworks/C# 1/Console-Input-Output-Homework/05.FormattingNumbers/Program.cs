using System;


namespace _05.FormattingNumbers
{

    /*Write a program that reads 3 numbers:
    integer a (0 <= a <= 500)
    floating-point b
    floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
    The number a should be printed in hexadecimal, left aligned
    Then the number a should be printed in binary form, padded with zeroes
    The number b should be printed with 2 digits after the decimal point, right aligned
    The number c should be printed with 3 digits after the decimal point, left aligned.*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a value for number A: ");
            int numA = int.Parse(Console.ReadLine());
            if (0 <= numA && numA <= 500)
            {
                Console.Write("Please enter a value for number B: ");
                float numB = float.Parse(Console.ReadLine());
                Console.Write("Please enter a value for number C: ");
                float numC = float.Parse(Console.ReadLine());
                string bitNum = Convert.ToString(numA, 2).PadLeft(10, '0');
                Console.WriteLine("|{0,-10:X}|{1}|{2,10:N2}|{3,-10:0.000}|", numA, bitNum, numB, numC);
            }
            else
            {
                Console.WriteLine("Your value is out of range, please restart the program.");

            }
        }
    }
}
