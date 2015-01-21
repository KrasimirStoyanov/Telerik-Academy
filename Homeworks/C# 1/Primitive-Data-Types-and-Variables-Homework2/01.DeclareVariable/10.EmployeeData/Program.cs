using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Pesho";
            string lastName = "Peshov";
            byte age = 25;
            char gender = 'M';
            long personalID = 8306112507;
            int uniqueID = 27560000;
            
            Console.WriteLine("Employee's name is: " + firstName + " " + lastName);
            Console.WriteLine("The age is: " + age);
            Console.WriteLine("The gender is: " + gender);
            Console.WriteLine("With personal ID: " + personalID);
            Console.WriteLine("And unique ID: " + uniqueID);
        }
    }
}
