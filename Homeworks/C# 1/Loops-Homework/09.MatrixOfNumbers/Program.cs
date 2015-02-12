using System;
namespace _09.MatrixOfNumbers
{

    //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
    //and prints a matrix like in the examples below. Use two nested loops.


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the value for n: ");
            int n = int.Parse(Console.ReadLine());
            if ((n >=1 ) && (n<=20))
            {
                Console.WriteLine("matrix");
                for (int i = 0; i < n; i++)
                {
                    //Console.WriteLine(i);
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write(i+j);
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Invalid input.");
        }
    }
}
