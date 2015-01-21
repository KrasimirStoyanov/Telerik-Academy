using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FloatOrDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstFloat = 12.345F;
            Console.WriteLine("Expected value is: 12.345 " + "Actual value is: " + firstFloat);
            float secondFloat = 3456.091F;
            Console.WriteLine("Expected value is: 3456.091 " + "Actual value is: "+secondFloat);
            double firstDouble = 34.567839023;
            Console.WriteLine("Expected value is: 34.567839023 " + "Actual value is: " + firstDouble);
            double secondDouble = 8923.1234857;
            Console.WriteLine("Expected value is: 8923.1234857 " + "Actual value is: " + secondDouble);
        }
    }
}
