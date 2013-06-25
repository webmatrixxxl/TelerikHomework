using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Generating_Permutations
{
    class Program
    {
        static bool[] used;
        static int[] array;

        static void Main(string[] args)
        {
            int end = 5;
            int start = 1;
            used = new bool[end];
            array = new int[end];

            Permute(end, 0, start);
        }

        static void Print(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + 1 + " ");
            }

            Console.WriteLine();
        }

        static void Permute(int n, int index, int start)
        {
            if (index >= n-start)
            {
                Print(n-start);
                return;
            }

            for (int i = start; i < n; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    array[index] = i;
                    Permute(n, index + 1, start);
                    used[i] = false;
                }
            }
        }
    }
}
