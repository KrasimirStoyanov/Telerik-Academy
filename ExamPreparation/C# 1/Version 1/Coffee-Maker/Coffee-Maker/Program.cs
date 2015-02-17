using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            double inMachine = n1 * 0.05 + n2 * 0.10 + n3 * 0.20 + n4 * 0.50 + n5 * 1.00;

            if (a >= p)
            {
                double change = a - p;
                if (change <= inMachine)
                {
                    Console.WriteLine("Yes there is change {0:F2}", inMachine - change);
                }
                else
                {
                    Console.WriteLine("No there is no change {0:F2}",inMachine );
                }
            }





        }
    }
}
