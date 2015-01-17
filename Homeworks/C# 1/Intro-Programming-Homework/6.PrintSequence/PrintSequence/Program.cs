using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 2; x <= 10;)
            {
                Console.Write(x++ + " ");
                Console.Write(-x++ + " ");
            }
        }
    }
}
