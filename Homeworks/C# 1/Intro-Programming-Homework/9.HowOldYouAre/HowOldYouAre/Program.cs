using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowOldYouAre
{
    class Program
    {
        static void Main(string[] args)
        {

            LocalDate birthday = new LocalDate(1976, 6, 19); // For example
            LocalDate today = LocalDateTime.FromDateTime(DateTime.Now).Date; // See below
            Period period = Period.Between(birthday, today);
            Console.WriteLine("You are {0} years, {1} months, {2} days old",
                              period.Years, period.Months, period.Days);
        }
    }
}
