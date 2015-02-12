using System;


namespace _07.CalculateNFactorialDividingAFormula
{
    /*In combinatorics, the number of ways to choose k different members out of a group of n different 
    elements (also known as the number of combinations) is calculated by the following formula: formula 
    For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) 
    for given n and k (1 < k < n < 100). Try to use only two loops. */


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the value for n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter the value for k: ");
            int k = int.Parse(Console.ReadLine());
            int factorial = 1;

            if ((k < 1) || (k > n) || (n > 100))
            {
                Console.WriteLine("Invalid input");
            }

            else
            {
                for (int i = 1; i <= k; i++)
                {
                    factorial *= n--;
                    factorial /= i;
                }
                Console.WriteLine("The result of n!/(k!*(n-k)!) is: {0}", factorial);
            }
        }
    }
}
