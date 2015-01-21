using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int? someInt = null;
            double? someDouble = null;
           
            Console.WriteLine(someInt);
            Console.WriteLine(someDouble);
            someInt = 1;
            someDouble = 1.5;
        
            Console.WriteLine(someInt);
            Console.WriteLine(someDouble);
        }
    }
}
