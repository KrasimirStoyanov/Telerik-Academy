using System;

namespace _06.CalculateNFactorialDividingKFactorial
{

   // Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
   // Use only one loop.
    class Class1
    {
        
        static void Main(string[] args)
        {
            Console.Write("Please enter the value for n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter the value for k: ");
            int k = int.Parse(Console.ReadLine());
            int temp = 1;
            int factorial = 1;

            if ((k < 1) || (k > n) || (n > 100))
                Console.WriteLine("Invalid input");
            else
            {
                for (int i = k+1 ; i <= n; i++)
                {
                    factorial = temp * i;
                    temp = factorial;
                }
                Console.WriteLine("The result of n!/k! is: {0}", factorial);
            }
        }
    }
}
