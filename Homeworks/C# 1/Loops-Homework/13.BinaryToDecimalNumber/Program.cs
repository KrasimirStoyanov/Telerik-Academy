using System;
namespace _13.BinaryToDecimalNumber
{

    //Using loops write a program that converts a binary integer number to its decimal form.
   //The input is entered as string. The output should be a variable of type long.
   //Do not use the built-in .NET functionality
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a binary number: ");
            string input = Console.ReadLine();
            long variable = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[input.Length - i - 1] == '0') 
                    continue;
                variable += (long) Math.Pow(2, i);
            }
            Console.WriteLine("The decimal form of the number is: " + variable);

        }
    }
}
