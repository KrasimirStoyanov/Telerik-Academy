using System;


namespace _08.NumbersFrom1ToN
{

    // Write a program that reads an integer number n from the console and prints all the numbers in the interval 
    // [1..n], each on a single line.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number to start the sequence: ");
            int sequenceNum = int.Parse(Console.ReadLine());
            for (int i = 1; i < sequenceNum+1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
