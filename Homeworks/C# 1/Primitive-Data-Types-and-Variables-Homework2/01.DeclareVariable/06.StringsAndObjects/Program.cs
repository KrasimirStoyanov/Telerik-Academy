﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object someObject = hello + " " + world;
            string castedString = (string)someObject;
            Console.WriteLine(castedString);
            
        }
    }
}
