using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
namespace _02.GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your weight in kilograms: ");
            string input = Console.ReadLine();
            double weight = double.Parse(input);

            double gravityWeight = weight * 0.17;
            Console.WriteLine("Your weight on the Moon would be: " + gravityWeight);
        }
    }
}
