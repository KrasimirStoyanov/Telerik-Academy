using System;


namespace _06.QuadraticEquation
{

    // Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
    // and solves it (prints its real roots).
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter value for number A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter value for number B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter value for number C: ");
            double c = double.Parse(Console.ReadLine());
            double sqrtPart = (b * b) - (4 * a * c);
            double x1 = ((-1) * b - Math.Sqrt(sqrtPart)) / (2 * a);
            double x2 = ((-1) * b + Math.Sqrt(sqrtPart)) / (2 * a);
            Console.WriteLine("The value for x1 is: {0} and the value for x2 is: {1}", x1,x2);

        }
    }
}
