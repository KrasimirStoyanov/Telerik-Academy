using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

class CompareArrays
{
     //•Write a program that reads two integer arrays from the console and compares them element by element.
    static void Main()
    {
        int[] firstInt = {1, 2, 3, 4, 5, 6, 7};
        int[] secondInt = { 2, 3, 4, 5, 6, 7, 8};
        int[] thirdInt = { 1, 2, 3, 4, 5, 6, 7 };

        //Linq method
        var firstAndSecondCompare = Enumerable.SequenceEqual(firstInt, secondInt);
        var firstAndThirdCompare = Enumerable.SequenceEqual(firstInt, thirdInt);

        Console.WriteLine("The first and the second arrays are equal? : " + firstAndSecondCompare);
        Console.WriteLine("The first and the third arrays are equal? : " + firstAndThirdCompare);
    }    
}





