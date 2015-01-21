using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            a += b;
            b *= a;
            Console.WriteLine("A is {0}, B is {1}", a, b);
        }
    }
}
