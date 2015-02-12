using System;

namespace _10.FibonacciNumbers
{

    //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the amount of Fibonacci numbers you want to print: ");
            int fibonacci = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            for (int i = 1; i <= fibonacci; i++)
            {
                c = a + b;
                Console.Write("{0}, ", c);
                a = b;
                b = c;
            }
            Console.WriteLine();
        }
    }
}
