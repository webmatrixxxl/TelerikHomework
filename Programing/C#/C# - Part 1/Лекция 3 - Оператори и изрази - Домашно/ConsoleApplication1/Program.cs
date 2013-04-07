using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number and findout third bit:");
            int num = int.Parse(Console.ReadLine());
            int p = 3; //Позиция на bit-а
            int mask = (num >> p) % 2;
            Console.WriteLine("The third bit of the digit is: {0}", mask);

        }
    }
}
