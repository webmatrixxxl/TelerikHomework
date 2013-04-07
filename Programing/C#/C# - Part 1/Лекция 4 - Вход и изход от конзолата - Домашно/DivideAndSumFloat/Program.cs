using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndSumFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = 1;
            decimal sum = 0;
            for (int i = 1; i<100; i++)
            {
                sum = Math.Round(sum, 3) + Math.Round(a / i, 3);

            }
            Console.WriteLine("{0:0.000}", sum);
        }
    }
}
