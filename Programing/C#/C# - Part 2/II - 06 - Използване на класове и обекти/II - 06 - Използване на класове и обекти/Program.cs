using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a year from the
//console and checks whether it is a leap. Use DateTime.

namespace II___06___Използване_на_класове_и_обекти
{
    class Program
    {
        static bool IsLeap(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }

        static void Main()
        {
            Console.Write("Enter a year: ");
            Console.WriteLine("Is year leep: {0}", IsLeap(int.Parse(Console.ReadLine())));
        }
    }
}
