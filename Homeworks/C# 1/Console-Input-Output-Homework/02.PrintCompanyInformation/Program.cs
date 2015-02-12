using System;


namespace _02.PrintCompanyInformation
{

   // A company has name, address, phone number, fax number, web site and manager. 
   // The manager has first name, last name, age and a phone number.
   // Write a program that reads the information about a company and its manager and prints it back on the console.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your company name");
            string nameCompany = Console.ReadLine();
            Console.WriteLine("Please enter the address of the company");
            string addresCompany = Console.ReadLine();
            Console.WriteLine("Please enter your phone number");
            int phoneNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the fax number");
            int faxNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your web side");
            string webSide = Console.ReadLine();
            Console.WriteLine("Please enter the first name of the manager");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name of the manager");
            string lastName = Console.ReadLine();
            Console.WriteLine("Please enter the age of the manager");
            byte ageManager = byte.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the phone of the manager");
            int phoneManager = int.Parse(Console.ReadLine());
            Console.WriteLine(nameCompany);
            Console.WriteLine("Address:" + addresCompany);
            Console.WriteLine("Tel:" + phoneNum);
            Console.WriteLine("Fax:" + faxNum);
            Console.WriteLine("Web side: http://" + webSide);
            Console.WriteLine("Manager: {0}{1} (Age: {2}, Tel: {3})", firstName, lastName, ageManager, phoneManager);
        }
    }
}
