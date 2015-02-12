using System;

namespace SumOf3Numbers
{

    //Write a program that reads 3 real numbers from the console and prints their sum.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the numbers is: {0}",number1+number2+number3);
        }
    }
}
