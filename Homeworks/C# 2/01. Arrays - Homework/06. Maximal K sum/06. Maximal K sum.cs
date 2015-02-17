using System;
using System.Linq;
using System.Collections.Generic;

class MaximalKSum
{
        /*•	Write a program that reads two integer numbers N and K and an array of N elements from the console.
          •	Find in the array those K elements that have maximal sum.*/
    static void Main()
    {
        Console.Write("Please enter N: ");
        int nElement = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter K: ");
        int kElement = Int32.Parse(Console.ReadLine());
        int[] array = new int[nElement];
        int bestSum = 1;
        int currentSum = 0;
        List<int> sequence = new List<int>();
        List<int> maxSumSequence = new List<int>();

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Please enter element of the Array: ");
            array[i] = Int32.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= array.Length - kElement; i++)
        {
            for (int j = i; j < kElement + i; j++)
            {
                currentSum += array[j];
                sequence.Add(array[j]);
            }
            if (currentSum > bestSum)
            {
                bestSum = currentSum;
                maxSumSequence.Clear();             
                maxSumSequence.AddRange(sequence);  
            }
            currentSum = 0;
            sequence.Clear();
        }
        Console.WriteLine("The best sum is: " +  bestSum);
       
    }
}

