using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that calculates trapezoid's area by given sides a and b and height h.
namespace _09.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the A side of the trapezoid: ");
            string aInput = Console.ReadLine();
            double aSide = double.Parse(aInput);

            Console.Write("Please enter the B side of the trapezoid: ");
            string bInput = Console.ReadLine();
            double bSide = double.Parse(bInput);

            Console.Write("Please enter trapezoid's height: ");
            string heightInput = Console.ReadLine();
            double height = double.Parse(heightInput);

            double trapezoidArea = ((aSide + bSide)/2)*height;

            Console.WriteLine("The area of the trapezoid is: " + trapezoidArea);

        }
    }
}
