using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReformat
{
    using System;
    class CodeReformat
    {
        static void Main()
        {
            Console.WriteLine("Hi, I am horribly formatted program!");
            Console.WriteLine("Numbers and squares:");
            for (int number = 0; number < 10; number++)
            {
                Console.WriteLine(number + " --> " + number * number);
            }
        }
    }
}
