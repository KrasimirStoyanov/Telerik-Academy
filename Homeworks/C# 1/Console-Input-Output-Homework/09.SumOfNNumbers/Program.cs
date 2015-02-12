using System;


namespace _09.SumOfNNumbers
{

    //Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the amount of numbers: ");
            double sequenceNum = double.Parse(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i < sequenceNum+1; i++)
            {
                Console.Write("Please enter the {0} number: ", i);
                double numI = double.Parse(Console.ReadLine());
                sum += numI;
            }
            Console.WriteLine("The sum of the numbers is: " + sum);
        }
    }
}
