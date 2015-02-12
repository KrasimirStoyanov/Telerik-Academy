using System;
namespace _05.CalculateFormula
{

  //  Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
  //  Use only one loop. Print the result with 5 digits after the decimal point.

    class main
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the value for n: ");
            int nInput = int.Parse(Console.ReadLine());
            Console.Write("Please enter the value for x: ");
            int xInput = int.Parse(Console.ReadLine());
            double factorial = 1;
            double sum = 1;

            for (int i = 1; i <= nInput; i++)
            {
                factorial *= i;
                sum += factorial/ Math.Pow(xInput,i);
            }
            Console.WriteLine("The sum is: {0:0.00000}",sum);
        }
    }
}
