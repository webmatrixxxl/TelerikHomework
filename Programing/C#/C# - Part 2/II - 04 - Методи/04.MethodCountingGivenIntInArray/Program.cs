using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is working correctly.


namespace _04.MethodCountingGivenIntInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[10] { 0, 5, 6, 6, 7, 8, 9, 1, 11, 9 };
            Console.WriteLine(countN(N, arr));

        }
        static int countN(int N, int[]arr)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if (N==item)
                {
                    count++;  
                }
            }
            return count;
        }
    }
}
