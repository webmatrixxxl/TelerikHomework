using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача12
{
    class AgeCalcolator
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            int now = DateTime.Now.Year;
            Console.WriteLine("In year " + (now+10) + " you will be "+ (age+10) + " years old"); 

        }
    }
}
