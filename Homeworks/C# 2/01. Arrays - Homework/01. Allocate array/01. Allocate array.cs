﻿using System;
using System.Linq;


class AllocateArray
{
     /*•Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
       •Print the obtained array on the console.*/
    static void Main()
    {
        int[] someInt = new int[20];
        for (int i = 0; i < someInt.Length; i++)
        {
            someInt[i] = i*5;
            Console.WriteLine(someInt[i]);
        }
       
    }
}
