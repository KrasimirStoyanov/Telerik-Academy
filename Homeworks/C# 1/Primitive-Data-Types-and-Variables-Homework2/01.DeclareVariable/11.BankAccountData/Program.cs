using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Pesho";
            string middleName = "Peshov";
            string lastName = "Peshov";
            //Pesho e spestil za bani4ka ;)
            double accountBalance = 1.50;
            string bankName = "Bankata na Pesho";
            string iban = "BG1234567890132";
            long firstCreditCardNumber = 68943534905736L;
            long secondCreditCardNumber = 34645764574564L;
            long thirdCreditCardNumber = 65463453453453L;

            Console.WriteLine("Account holder: {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Account balance: {0} BGN", accountBalance);
            Console.WriteLine("Bank: {0}", bankName); ;
            Console.WriteLine("IBAN: {0}", iban);
            Console.WriteLine("Credit cards numbers: 1. {0}; 2. {1}; 3. {2}.", firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
        }
    }
}
