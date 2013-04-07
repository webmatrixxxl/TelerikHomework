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
            
            int S = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int lenghtCount=0;
            int maxI = 1;
            string subSet = null;
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
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
                        subSet += arr[j] + " ";
                        lenghtCount++;
                    }
                }
                if (currentSum == S && lenghtCount == K)
                {
                    count++;
                    Console.WriteLine("Number of subest with sum of {0}",S);
                    Console.WriteLine("{0} subsets have sum of {1}",subSet,S);
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No subsets wiht sum of {0}",S);
            }
           
        }
    }
}
