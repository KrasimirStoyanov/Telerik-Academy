using System;

namespace _03.MinMaxSumAndAverageOfNNumbers
{

   //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
   //the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
   //The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
   //The output is like in the examples below.
    class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number for the lenght of the sequence: ");
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;

            for (int i = 1; i <= input; i++)
            {
                Console.Write("Please enter a number: ");
                int number = int.Parse(Console.ReadLine());
                sum = sum + number;
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            double average = ((double) sum /(double) input);
            Console.WriteLine("The sum of the sequence is: " + sum);
            Console.WriteLine("The max number is: " + maxNumber);
            Console.WriteLine("The min number is: " + minNumber);
            Console.WriteLine("The average of the sequence is: " + average);

        }
    }
}
