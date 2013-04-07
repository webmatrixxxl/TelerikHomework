using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumbersToNnotDevidetBy3and7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter N integer: ");
            int n = int.Parse(Console.ReadLine());
            int[] sequence;
            for (int i = 0; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    sequence = int.Parse(Console.ReadLine());
                    Console.WriteLine(i);
                }


            }

         
        }
    }
}