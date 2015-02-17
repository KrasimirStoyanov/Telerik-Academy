using System;
using System.Linq;
using System.Collections.Generic;


class MaximalIncreasingSequence
{
    //•	Write a program that finds the maximal increasing sequence in an array.
    static void Main()
    {
        var seq = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        var bestSeq = new List<int>();
        var currentNumber = new List<int>();

        for (int i = 0; i < seq.Length-1; i++)
        {
            if ((seq[i] < seq[i+1]) && ((seq[i+1] - seq[i]) == 1))
            {
               currentNumber.Add(seq[i]);
                    currentNumber.Add(seq[i] + 1);

                    if (currentNumber.Count > bestSeq.Count)
                    {
                        bestSeq.Clear();
                        bestSeq.AddRange(currentNumber);
                    }
            }
                else
                {
                    currentNumber.Clear();
                }
        }
        List<int> increasingElements = bestSeq.Distinct().ToList();
        Console.Write("The best subsequence is: ");
        increasingElements.ToList().ForEach(i => Console.Write(i.ToString() + " "));
        Console.WriteLine();
     }
        
        //Console.WriteLine("asd" + bestElement);
        //Console.WriteLine("Best Length is " + bestLength);
}

