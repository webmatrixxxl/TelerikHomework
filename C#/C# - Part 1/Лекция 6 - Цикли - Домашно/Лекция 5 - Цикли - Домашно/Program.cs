using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лекция_5___Цикли___Домашно
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter N integer: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine(i);


            }
        }
    }
}
