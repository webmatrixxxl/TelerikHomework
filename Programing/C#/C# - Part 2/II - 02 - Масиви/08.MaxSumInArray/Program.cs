using System;

//Write a program that finds the sequence of maximal sum in given array. Example:
//    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//    Can you do it with only one loop (with single scan through the elements of the array)?


class SequenceOfMaximalSum
{
    static void Main()
    {
        Console.WriteLine("Enter arr length:");
        int length = int.Parse(Console.ReadLine());
        int[] arr = new int[length];
        //enter array elements
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        int max = arr[0], maxEnd = arr[0];
        int longSequence = 1, currentSequence = 1;
        int start = 0, startTemp = 0;
        //Kadane's algorithm
        for (int i = 1; i < arr.Length; ++i)
        {
            if (arr[i] + maxEnd > arr[i])
            {
                maxEnd = arr[i] + maxEnd;
                currentSequence++;
            }
                
            else
            {
                maxEnd = arr[i];
                startTemp = i;
                currentSequence = 1;
            }
            if (maxEnd > max)
            {
                max = maxEnd;
                longSequence = currentSequence;
                start = startTemp;
            }
        }
        //print array
        for (int i = start; i < start + longSequence; ++i)
        {
            Console.Write("{0} ", arr[i]);
        }
    }
}
