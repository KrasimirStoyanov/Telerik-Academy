using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithIntDoubleAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:\n 1--> int\n 2--> double\n 3--> string");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter an integer: ");
                    int input1 = int.Parse(Console.ReadLine());
                    Console.WriteLine(input1 + 1);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double input2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(input2 + 1);
                    break;
                case 3:
                    Console.Write("Please, enter a string: ");
                    string input3 = Console.ReadLine();
                    Console.WriteLine(input3 + "*");
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
