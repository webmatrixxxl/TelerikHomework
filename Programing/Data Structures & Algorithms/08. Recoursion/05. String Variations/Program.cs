using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.String_Variations
{
    class Program
    {
        static string num;
        static string[] result;
        static string[] input;
        static bool[] used;

        static void Main(string[] args)
        {
            input = new string[] { "hi", "a", "b" };
            result = new string[input.Length];

            //used for memoization, shows if the index number was already used
            used = new bool[result.Length];

            GeneratePermutations(0, 2);
        }

        private static void GeneratePermutations(int index, int k)
        {
            if (index >= k)
            {
                Console.WriteLine(string.Join(" ", result));
                return;
            }

            for (int i = 0; i < result.Length; i++)
            {

                result[index] = input[i];
                used[i] = true;
                GeneratePermutations(index + 1, k);
                used[i] = false;
            }
        }
    }
}
