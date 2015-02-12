using System;
namespace _15.HexadecimalToDecimalNumber
{

    //Using loops write a program that converts a hexadecimal integer number to its decimal form.
    //The input is entered as string. The output should be a variable of type long.
    //Do not use the built-in .NET functionality.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a hexadecimal number: ");
            string input = Console.ReadLine();
            long output = 0;
            int lastIndex = input.Length - 1;
            long hex = 1;

            for (int i = 0; i < input.Length; i++, lastIndex--)
            {
                int num;
                switch (input[i])
                {
                    case 'A': num = 10;
                        break;
                    case 'B': num = 11;
                        break;
                    case 'C': num = 12;
                        break;
                    case 'D': num = 13;
                        break;
                    case 'E': num = 14;
                        break;
                    case 'F': num = 15;
                        break;
                    default: num = int.Parse(input[i].ToString());
                        break;
                }

                for (int j = 0; j < lastIndex; j++)
                {
                    hex *= 16;
                }
                hex *= num;
                output += hex;
            }
            Console.WriteLine("The decimal form of the number is: " + output);   
        }
    }
}
