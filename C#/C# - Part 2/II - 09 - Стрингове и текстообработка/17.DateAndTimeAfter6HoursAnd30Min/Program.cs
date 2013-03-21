using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a date and time given in the 
//format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) 
//along with the day of week in Bulgarian.


namespace _17.DateAndTimeAfter6HoursAnd30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = "24.01.2013 23:00:00";
            DateTime now = DateTime.Parse(start).Add(new TimeSpan(6, 30, 0));
            Console.WriteLine("{0}, {1}",now.ToString("dddd",new CultureInfo("bg-BG")),now);
        }
    }
}
