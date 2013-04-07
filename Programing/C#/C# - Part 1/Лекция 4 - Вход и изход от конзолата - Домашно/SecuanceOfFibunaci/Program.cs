using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuanceOfFibunaci
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = 100;
            decimal a = 0;
            decimal b = 1;
            // n e се ограницава размера на редицата
            for (int i = 0; i < n; i++)
            {
               
                decimal temp = a;
                Console.Write(a);
                a = b;
                b = temp + b;
                
            }
        }
    }
}
