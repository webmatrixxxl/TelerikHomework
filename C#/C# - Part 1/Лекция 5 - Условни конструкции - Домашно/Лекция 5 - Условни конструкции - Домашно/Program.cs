using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лекция_5___Условни_конструкции___Домашно
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write first integer ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Write second integer ");
            int s = int.Parse(Console.ReadLine());
            if (f > s)
            {
                int buffer = f;
                f = s;
                s = buffer;
               
            }
        }
    }
}
