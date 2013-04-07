using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.SubSetOfArrayWithSumS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[8] { 2, 1, 2, 4, 3, 5, 2, 6 };
            int S = int.Parse(Console.ReadLine());

            int maxI = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                maxI *= 2;
            }
            maxI -= 1;
            int count = 0;
            for (int i = 1; i <= maxI; i++)
            {
                long currentSum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        currentSum += arr[j];
                    }
                }
                if (currentSum == S)
                {
                    count++;
                }
            }
            if (count>0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
