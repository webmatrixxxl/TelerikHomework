using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Forest_Road
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            int o = 1;
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 2 * N - 1; i++)
            {
                for (int c = 1; c <= N; c++)
                {

                    if (c == p)
                    {

                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }

                if (p < N && o <= 1)
                {

                    p++;

                }
                else
                {
                    o = N;
                }
                if (o > 1)
                {
                    o--;
                    p--;
                }

                Console.WriteLine();
            }
        }
    }
}
