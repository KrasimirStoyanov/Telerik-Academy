using System;
namespace _08.CatalanNumbers
{

    // Check the Catalan formula in Wikipedia
    // Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the value for n: ");
            int n = int.Parse(Console.ReadLine());

            if ((n < 0) || (n > 101))
            {
                Console.WriteLine("Invalid input");
            }

            else
            {
                
                Console.WriteLine("The Catalan number is: {0}", catalan(n));
            }
        }

        public static long catalan(long n) 
        {
            if (n == 1)
                return 1;
            else
            {
                n = n - 1;
            }
                return ((catalan(n) * (2*n+2) * (2*n+1))/((n+1)*(n+2)));
        }
    }
}
