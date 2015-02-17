using System;
using System.Linq;

class CompareCharArrays
{
    //•	Write a program that compares two char arrays lexicographically (letter by letter).
    static void Main()
    {
        char[] firstCharArray = { 'a', 'b', 'c' };
        char[] secondCharArray = { 'b', 'c', 'a' };
        char[] thirdCharArray = { 'a', 'b', 'c' };

        //Linq method
        var firstAndSecondCompare = Enumerable.SequenceEqual(firstCharArray, secondCharArray);
        var firstAndThirdCompare = Enumerable.SequenceEqual(firstCharArray, thirdCharArray);

        Console.WriteLine("The first and the second arrays are equal? : " + firstAndSecondCompare);
        Console.WriteLine("The first and the third arrays are equal? : " + firstAndThirdCompare);
    }
}
