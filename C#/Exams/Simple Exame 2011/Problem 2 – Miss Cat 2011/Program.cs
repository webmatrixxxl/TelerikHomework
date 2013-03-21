using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Miss_Cat_2011
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cat = new int[11];
            int bestcat = 0;
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; 0 < N; N--)
            {
                i = int.Parse(Console.ReadLine());

                cat[i]++;
                if (cat[i] > cat[bestcat])
                {
                    bestcat = i;
                }
            }
            Console.WriteLine(bestcat);

        }
    }
}
