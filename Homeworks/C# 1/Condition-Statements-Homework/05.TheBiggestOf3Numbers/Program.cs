using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheBiggestOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter the third number: ");
            double c = double.Parse(Console.ReadLine());

            double biggestNum = a;
            if (b > biggestNum) biggestNum = b;
            if (c > biggestNum) biggestNum = c;
            Console.WriteLine("The biggest number is: " + biggestNum);
        }
    }
}


