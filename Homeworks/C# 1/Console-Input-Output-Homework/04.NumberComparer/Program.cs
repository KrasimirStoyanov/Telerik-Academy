using System;

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

namespace _04.NumberComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            double firstNum = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double secondNum = double.Parse(Console.ReadLine());
            double biggerNum = Math.Max(firstNum, secondNum);
            Console.WriteLine("The bigger number is: {0}", biggerNum);
        }
    }
}
