using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
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

              if (a == 0 || b == 0 || c == 0)
              {
                 Console.WriteLine("Result is 0");
              }

              else if (a > 0)
              {
                  if (b > 0)
                  {
                      if (c > 0)
                      {
                          Console.WriteLine("The sign is +");
                      }
                      else
                      {
                          Console.WriteLine("The sign is -");
                      }
                  }
                  else
                  {
                      if (c > 0)
                      {
                          Console.WriteLine("The sign is -");
                      }
                      else
                      {
                          Console.WriteLine("The sign is +");
                      }
                  }
              }

              else
              {
                  if (b > 0)
                  {
                      if (c > 0)
                      {
                          Console.WriteLine("The sign is -");
                      }
                      else
                      {
                          Console.WriteLine("The sign is +");
                      }
                  }
                  else
                  {
                      if (c > 0)
                      {
                          Console.WriteLine("The sign is +");
                      }
                      else
                      {
                          Console.WriteLine("The sign is -");
                      }
                  }
              }
        }
    }
}
