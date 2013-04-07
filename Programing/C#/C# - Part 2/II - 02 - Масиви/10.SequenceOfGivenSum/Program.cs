using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds in given array of integers a sequence
//of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	


namespace _10.SequenceOfGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int S = int.Parse(Console.ReadLine());
            int[] array = new int[7] { 4, 3, 1, 4, 2, 5, 8 };
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (sum>S)
                {
                    sum = array[i];
                }
                if (sum==S)
                {
                    int m = i;
                    while (0 < sum)
                    {
                        Console.Write(array[m]);
                        sum -= array[m];
                        m--;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
