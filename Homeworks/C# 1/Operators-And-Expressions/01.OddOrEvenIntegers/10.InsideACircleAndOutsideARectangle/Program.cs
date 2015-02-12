using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//and out of the rectangle R(top=1, left=-1, width=6, height=2).
namespace _10.InsideACircleAndOutsideARectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter point x : ");
            string pointXInput = Console.ReadLine();
            double xPoint = double.Parse(pointXInput);

            Console.Write("Please enter point y : ");
            string pointYInput = Console.ReadLine();
            double yPoint = double.Parse(pointYInput);

            double radius = 1.5;
            double side = 1;

            if ((((xPoint - side) * (xPoint - side)) + ((yPoint - side) * (yPoint - side))) <= (radius * radius))
            {
                if (yPoint > side)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
