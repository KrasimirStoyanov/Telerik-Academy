using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 2; x <= 1000; )
            {
                Console.Write(x++ + " ");
                Console.Write(-x++ + " ");
            }
        }
    }
}
