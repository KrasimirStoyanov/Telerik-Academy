using System;


namespace _03.CirclePerimeterAndArea
{

    //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            double area = (radius * radius) * Math.PI;
            double perimeter = (Math.PI * radius) * 2;
            Console.WriteLine("The area of the circle is {0} \nIts perimeter is {1}", area, perimeter);
        }
    }
}
