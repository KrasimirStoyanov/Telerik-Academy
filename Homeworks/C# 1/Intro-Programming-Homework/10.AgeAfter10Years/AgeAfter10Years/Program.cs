using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your year of birth :");
            int yearOfBirth = int.Parse(Console.ReadLine());
            int currentYear = DateTime.Now.Year;
            if (yearOfBirth >= 1900 && yearOfBirth < currentYear)
            {
                int ageNow = currentYear - yearOfBirth;
                int ageAfter = ageNow + 10;
                Console.WriteLine("Your age now is {0}, but your age in 10 years will be {1}", ageNow, ageAfter);
            }
            else
                Console.WriteLine("Incorrect date");
        }
    }
}
