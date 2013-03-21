using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:
//        Enter the first date: 27.02.2006
//        Enter the second date: 3.03.2004
//        Distance: 4 days


namespace _16.ReadTwoDatesAndCalcolateDaysBetwine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter date in format: dd.mm.yyyy and calcolate days beatwine your date and 03.03.2125: ");
            string start = Console.ReadLine();
            string end = "03.03.2125";

            DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(Math.Abs(( startDate - endDate).TotalDays));
        }
    }
}
