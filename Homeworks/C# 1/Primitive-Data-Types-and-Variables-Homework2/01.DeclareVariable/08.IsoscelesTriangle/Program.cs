using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IsoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            char someChar = '\u00a9';

            Console.WriteLine("   " + someChar + "   ");
            Console.WriteLine("  " + someChar + " " + someChar + "  ");
            Console.WriteLine(" " + someChar + "   " + someChar + " ");
            Console.WriteLine("{0} {0} {0} {0}", someChar);
        }
    }
}
