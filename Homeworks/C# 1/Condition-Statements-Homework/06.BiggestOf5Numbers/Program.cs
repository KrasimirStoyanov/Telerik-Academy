using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BiggestOf5Numbers
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
            Console.Write("Please enter the fourth number: ");
            double d = double.Parse(Console.ReadLine());
            Console.Write("Please enter the fifth number: ");
            double e = double.Parse(Console.ReadLine());

            double biggestNum = a;
            if (b > biggestNum) biggestNum = b;
            if (c > biggestNum) biggestNum = c;
            if (d > biggestNum) biggestNum = d;
            if (e > biggestNum) biggestNum = e;
            Console.WriteLine("The biggest number is: " + biggestNum);
        }
    }
}
