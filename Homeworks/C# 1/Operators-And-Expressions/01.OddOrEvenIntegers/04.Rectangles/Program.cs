using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
namespace _04.Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter rectangle's width: ");
            string widthInput = Console.ReadLine();
            int width = int.Parse(widthInput);

            Console.Write("Please enter rectangle's height: ");
            string heightInput = Console.ReadLine();
            int height = int.Parse(heightInput);

            int perimeter = (2 * width) + (2 * height);
            int area = width*height;

            Console.WriteLine("The perimeter of the recrangle is: " + perimeter);
            Console.WriteLine("The area of the recrangle is: " + area);
        }
    }
}
