using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DeclareVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            byte someByte = 97;
            sbyte someSByte = -115;
            short someShort = -10000;
            ushort someUShort = 52130;
            int someInt = 4825932;

            Console.WriteLine("Expected value of Byte is : 97 " + "The value of byte is: "+someByte);
            Console.WriteLine("Expected value of sByte is : -115 " + "The result is: " + someSByte);
            Console.WriteLine("Expected value of Short is : -10000 " + "The value of short is: "+someShort);
            Console.WriteLine("Expected value of uShort is : 52130 " + "The value of byte is: "+someUShort);
            Console.WriteLine("Expected value of Int is : 4825932 " + "The value of byte is: " + someInt);
        }
    }
}
