using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that checks if the element at given position in given array
//of integers is bigger than its two neighbors (when such exist).


namespace _05.MethodBiggeerTheanNeighbors
{
    class Program
    {
        static void Main(string[] args)
        {

            int position = int.Parse(Console.ReadLine());
            int[] arr = new int[10] { 0, 5, 6, 6, 7, 8, 9, 1, 11, 9 };
            CheckNeighbors(position, arr);

        }
        static void CheckNeighbors(int position, int[] arr)
        {
            if (position == arr.Length - 1 && arr[position] > arr[position - 1] || position == 0 && arr[position] > arr[position + 1])
            {

                Console.WriteLine(true);
            }
            else if (position > 0 && position < arr.Length - 1)
            {
                if (arr[position] > arr[position + 1] && arr[position] > arr[position - 1])
                {
                    Console.WriteLine(true);
                }

            }
            else if (position > arr.Length - 1)
            {
                Console.WriteLine("Out of range");
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
