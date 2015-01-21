using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write the first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Please write the second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            Console.WriteLine(Math.Abs(firstNumber - secondNumber) < eps);
        }
    }
}
