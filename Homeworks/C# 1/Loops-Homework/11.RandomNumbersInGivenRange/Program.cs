using System;
namespace _11.RandomNumbersInGivenRange
{

    //Write a program that enters 3 integers n, min and max (min != max) and 
    //prints n random numbers in the range [min...max].

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter min: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Please enter max: ");
            int max = int.Parse(Console.ReadLine());

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write(rand.Next(min, max + 1) + " ");
            }
        }
    }
}
