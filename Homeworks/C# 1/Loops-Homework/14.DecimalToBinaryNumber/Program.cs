using System;
namespace _14.DecimalToBinaryNumber
{

  //Using loops write a program that converts an integer number to its binary representation.
  //The input is entered as long. The output should be a variable of type string.
  //Do not use the built-in .NET functionality.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a binary number: ");
            long input = long.Parse(Console.ReadLine());
            string output = "";
          
            if (input == 0)
            {
                Console.WriteLine("The binary form of the number is: 0");
            }
            else
            {
                while (input >= 1)
                {
                    output = (input % 2) + output;
                    input = input / 2;
                }
                Console.WriteLine("The binary form of the number is: {1}", input, output);   
            }
        }     
    }
}
