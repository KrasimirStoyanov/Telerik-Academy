using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 256; i++)
            {
                char a = (char)i;
                Console.WriteLine(a);
            }
        }
    }
}
