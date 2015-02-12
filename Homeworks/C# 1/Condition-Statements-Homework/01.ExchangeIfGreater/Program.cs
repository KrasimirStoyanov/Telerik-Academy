using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeIfGreater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the first number: ");
            double number1 = double.Parse((Console.ReadLine()));
            Console.Write("Please enter the first number: ");
            double number2 = double.Parse((Console.ReadLine()));

            if (number1 > number2)
            {
                double tempNumber = number1;
                number1 = number2;
                number2 = tempNumber;
                Console.WriteLine(number1 +" " + number2);
            }
            else
                Console.WriteLine(number1 + " " + number2);
          

        }
    }
}
