using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the index of given element in a sorted array
//of integers by using the binary search algorithm (find it in Wikipedia).


namespace _11.IndexOfElementInSortedArrayBinary
{
    class Program
    {
        static int BinSearch(int[] array, int key)
        {
            Array.Sort(array);
            int Max = array.Length - 1;
            int Min = 0;
            while (Max >= Min)
            {
                int Mid = (Min + Max) / 2;
                if (array[Mid] < key)
                {
                    Min = Mid + 1;
                }
                else if (array[Mid] > key)
                {
                    Max = Mid - 1;
                }
                else
                {
                    return Mid;
                }
            }
            return -1;
        }
        static void Main()
        {
            int[] myArray = { 4, 3, 1, 4, 2, 5, 8, 21, 13, 180 };
            int key = 3;
            Console.WriteLine(BinSearch(myArray, key));
        }
    }
}
