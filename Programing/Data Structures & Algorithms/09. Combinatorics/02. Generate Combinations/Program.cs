using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Generate_Combinations
{
    class Program
    {
        // N chose K
        static int[] array;

        static void Main(string[] args)
        {
            int n = 5;
            int k = 3;

            array = new int[k];

            Combinations(n, k, 1, 0);
        }

        static void Print(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        static void Combinations(int n, int k, int index, int after)
        {
            if (index > k)
            {
                return;
            }

            for (int j = after + 1; j <= n; j++)
            {

                array[index - 1] = j;

                if (index == k)
                {
                    Print(index);
                }

                Combinations(n, k, index + 1, j);
            }
        }
    }
}
