using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program, that reads from the console an array of N integers and an integer K,
//sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 


namespace _04.FindKOrLessInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int Result;
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            if (arr[0] > K) Console.WriteLine("There is no number that is less than or equal to K.");
            else
            {
                int IndexOfElement = Array.BinarySearch(arr, K);
                if (IndexOfElement >= 0)
                {
                    Result = arr[IndexOfElement];
                }
                else
                {
                    Result = arr[~IndexOfElement - 1];
                }
                Console.WriteLine(Result);
            }


        }
    }
}
