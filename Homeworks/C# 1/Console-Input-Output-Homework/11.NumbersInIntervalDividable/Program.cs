using System;


namespace _11.NumbersInIntervalDividable
{

    //Write a program that reads two positive integer numbers and prints how many numbers p 
    //exist between them such that the reminder of the division by 5 is 0.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            int number2 = int.Parse(Console.ReadLine());

            for (int i = number1; i <= number2; i++)
			{
                if ((i % 5) == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("0");
                    break;
                }
			}
        }
    }
}
