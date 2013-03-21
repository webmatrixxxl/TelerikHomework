using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a program that reads two integer numbers N and K and an array of N elements
// from the console. Find in the array those K elements that have maximal sum.
// N>K


namespace _06.MaxSumOfKinArrayOfN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            int K = int.Parse(Console.ReadLine());
            int bestSum = 0;
            int[] array = new int[8] { 1, 2, 3, 4, 5, 8, 9, 8 };

            Array.Sort(array);
            Array.Sort<int>(array,
                    new Comparison<int>(
                            (i1, i2) => i2.CompareTo(i1)
                    ));


            for (int c = 0; c < K; c++)
            {
                bestSum += array[c];

            }
            Console.WriteLine(bestSum);
        }
    }
}
