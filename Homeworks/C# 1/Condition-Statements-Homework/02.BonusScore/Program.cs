using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give a score from 1 to 9 : ");
            int score = int.Parse(Console.ReadLine());

            if (score >= 1 && score <= 3)
            {
                Console.WriteLine("The bonus score is: " + score * 10);
            }
            else if (score >= 4 && score <= 6)
            {
                Console.WriteLine("The bonus score is: " + score * 100);
            }
            else if (score >= 7 && score <= 9)
            {
                Console.WriteLine("The bonus score is: " + score * 1000);
            }
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
