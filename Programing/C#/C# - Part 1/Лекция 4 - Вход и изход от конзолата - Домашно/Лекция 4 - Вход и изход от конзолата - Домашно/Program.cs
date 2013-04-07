using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лекция_4___Вход_и_изход_от_конзолата___Домашно
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter fisrt integr:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third integr:");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("The SUM a,b and c is: {0}",a+b+c);

        }
    }
}
