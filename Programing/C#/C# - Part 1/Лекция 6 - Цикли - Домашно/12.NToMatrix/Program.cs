using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NToMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,p=1;
            string inputN = null;
            while (!int.TryParse(inputN, out N) || (N <= 0 || N >19))
            {
                Console.Write("Enter N to fit N<20: ");
                inputN = Console.ReadLine();

            }
            for (int i = 1; i <= N; i++)
            {
                Console.Write(i);
                p = i + 1;
                for (int c = 1; c < N; c++,p++)
                {
                    
                    Console.Write("{0,2}",p);
                    if (c==N-1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
