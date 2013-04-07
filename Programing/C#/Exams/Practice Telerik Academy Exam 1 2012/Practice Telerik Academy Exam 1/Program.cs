using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Telerik_Academy_Exam_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            DateTime data = new DateTime(year, month, day);
            Console.WriteLine("{0:d.M.yyyy}",data.AddDays(1));
        }
    }
}