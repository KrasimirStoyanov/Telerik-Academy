using System;

namespace _01.NumbersFrom1ToN
{


    //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n,
    //on a single line, separated by a space.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
