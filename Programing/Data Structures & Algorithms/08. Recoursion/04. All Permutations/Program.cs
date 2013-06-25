using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.All_Permutations
{
    class Program
    {
        static int num;
        static int[] result;
        static bool[] used;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter N, for permutations from 1 to N:");
            num = int.Parse(Console.ReadLine());
            result = new int[num];
            //used for memoization, shows if the index number was already used
            used = new bool[num + 1];

            GeneratePermutations(0);
        }

        private static void GeneratePermutations(int index)
        {
            if (index >= num)
            {
                Console.WriteLine(string.Join(", ", result));
                return;
            }

            for (int i = 1; i <= num; i++)
            {
                if (!used[i])
                {
                    result[index] = i;
                    used[i] = true;
                    GeneratePermutations(index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
