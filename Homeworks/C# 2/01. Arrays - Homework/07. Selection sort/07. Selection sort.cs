using System;
using System.Linq;
using System.Collections.Generic;

class SelectionSort
{
        /*•	Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
          •	Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the 
          smallest from the rest, move it at the second position, etc.*/
    static void Main()
    {
        var seq = new int[] { 5,7,2,3,4,11,1,9 };     
        int iMin;

        Console.Write("The sorted sequence is: ");
        for (int j = 0; j < seq.Length; j++)
        {
           
            iMin = j;         
            for (int i = j + 1; i < seq.Length; i++)
            {
                if (seq[i] < seq[iMin])
                {         
                    iMin = i;
                }
            }

            if (iMin != j)
            {
                int temp = seq[j];
                seq[j] = seq[iMin];
                seq[iMin] = temp;
            }
            Console.Write(seq[j] + " ");
        }
        Console.WriteLine();
            
    }
}
