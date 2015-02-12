using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sort3NumbersWithNestedIfs
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

            if (a > b)
            {
                if (a > c)
                {
                    if (c > b)
                    {
                        Console.WriteLine(a + " " + c + " " + b);
                    }
                    else
                    {
                        Console.WriteLine(a + " " + b + " " + c);
                    }
                }
                else
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        Console.WriteLine(b + " " + a + " " + c);
                    }
                    else
                    {
                        Console.WriteLine(b + " " + c + " " + a);
                    }
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
        }
    }
}
