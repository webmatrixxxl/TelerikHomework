using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _N
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1<!N :");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter  1<!K<!N ");
            int k = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = (k + 1); i <= n; i++)
            {
                result *=  i;

            }
            Console.WriteLine(result);
        }


    }
}
