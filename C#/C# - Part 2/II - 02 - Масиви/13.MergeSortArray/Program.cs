using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).


namespace _13.MergeSortArray
{
    class Program
    {


        static void Main()
        {

            int[] arrayOfIntegers = { 2, 8, 7, 1, 2, 3, 5, 6, 7 };
            int[] sortedArray = MergeSort(arrayOfIntegers);

            foreach (var item in sortedArray)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
        static int[] MergeSort(int[] array)
        {
            if (array.Length<=1)
            {
                return array;
            }
            int middle = array.Length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[array.Length - middle];
            for (int i = 0; i < middle; i++)
            {
                leftArray[i] = array[i];
            }
            for (int i = middle,c=0; i < array.Length; i++, c++)
            {
                rightArray[c] = array[i];
            }

            leftArray = MergeSort(leftArray);
            rightArray = MergeSort(rightArray);

            return MergeArrays(leftArray, rightArray) ;
        }

        static int[] MergeArrays(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int leftIncrease = 0;
            int rightIncrease = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (rightIncrease==right.Length || ((leftIncrease<left.Length)&&(left[leftIncrease]<=right[rightIncrease])))
                {
                    result[i] = left[leftIncrease];
                    leftIncrease++;
                }
                else if (leftIncrease == left.Length || ((rightIncrease < right.Length) && (right[rightIncrease] <= left[leftIncrease])))
                {
                    result[i] = right[rightIncrease];
                    rightIncrease++;
                }
            }
            return result;
        }
    }
}
