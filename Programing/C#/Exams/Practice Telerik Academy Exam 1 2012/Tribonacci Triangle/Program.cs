using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            long temp;
            long temp1 = long.Parse(Console.ReadLine());
            long temp2 = long.Parse(Console.ReadLine());
            long temp3 = long.Parse(Console.ReadLine());
            byte L = byte.Parse(Console.ReadLine());
            Console.WriteLine(" " + temp1);
            Console.WriteLine(" " + temp2 + " " + temp3);
            for (int i = 3; i <= L; i++)
            {

              
                for (int c = 1; c <= i; c++)
                {
                    temp = temp1+temp2+temp3;
                    temp1 = temp2;
                    temp2 = temp3;
                    temp3 = temp;
                    Console.Write(" "+temp);
                }
                Console.WriteLine();
            }
        }
    }
}
