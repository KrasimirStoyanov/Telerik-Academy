using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
namespace _07.PointInACircle
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

            int radius = 2;
            bool pointChecker = (xPoint * xPoint + yPoint * yPoint) <= radius * radius;
            Console.WriteLine("Is the point in the circle: " + pointChecker);
        }
    }
}
