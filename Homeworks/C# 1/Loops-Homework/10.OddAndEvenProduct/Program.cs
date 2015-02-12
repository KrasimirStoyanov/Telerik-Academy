using System;
namespace _10.OddAndEvenProduct
{

 // You are given n integers (given in a single line, separated by a space).
 //Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 //Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter n : ");
            string[] numbers = Console.ReadLine().Split();
            int[] myInts = Array.ConvertAll(numbers, int.Parse);

            int oddSum = 1;
            int evenSum = 1;

            for (int i = 0; i < myInts.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    oddSum *= myInts[i];
                }
                else
                    evenSum *= myInts[i];
            }
            Console.WriteLine("Odd numbers equal to: " +oddSum);
            Console.WriteLine("Even numbers equal to: " + evenSum);

            if (oddSum == evenSum)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

        }
    }
}
