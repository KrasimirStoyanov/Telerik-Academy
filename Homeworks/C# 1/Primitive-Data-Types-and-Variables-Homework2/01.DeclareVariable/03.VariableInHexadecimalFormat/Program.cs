using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int someInt = 254;
            string someHex = someInt.ToString("X");
            Console.WriteLine("The in 254 in Hexadecimal form is: " +someHex);
        }
    }
}
