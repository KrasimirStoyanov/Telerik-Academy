using System;
namespace _16.DecimalToHexadecimalNumber
{

    //Using loops write a program that converts an integer number to its hexadecimal representation.
    //The input is entered as long. The output should be a variable of type string.
    //Do not use the built-in .NET functionality.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a decimal number: ");
            long input = long.Parse(Console.ReadLine());

            string output = "";

            while (input > 0)
            {
                long n = input % 16;
                input /= 16;
                switch (n)
                {
                    case 10: 
                        output = "A" + output;
                        break;
                    case 11: 
                        output = "B" + output;
                        break;
                    case 12: 
                        output = "C" + output;
                        break;
                    case 13: 
                        output = "D" + output;
                        break;
                    case 14: 
                        output = "E" + output;
                        break;
                    case 15: 
                        output = "F" + output;
                        break;
                    default: 
                        output = n + output;
                        break;
                }
            }
            Console.WriteLine("The hexadecimal form of the number is: " + output);
        }
    }
}
