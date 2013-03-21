using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the index of the first element in array that is bigger 
//than its neighbors, or -1, if there’s no such element.
//Use the method from the previous exercise.


namespace _06.FirstBiggerThanItsNeighbors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 0, 5, 6, 6, 7, 8, 9, 1, 11, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckNeighbors(i, arr) == true)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        static bool CheckNeighbors(int position, int[] arr)
        {
            bool check = false;
            if (position == arr.Length - 1 && arr[position] > arr[position - 1] || position == 0 && arr[position] > arr[position + 1])
            {
                check = true;
            }
            else if (position > 0 && position < arr.Length - 1)
            {
                if (arr[position] > arr[position + 1] && arr[position] > arr[position - 1])
                {
                    check = true;
                }
            }
            else if (position > arr.Length - 1)
            {
                Console.WriteLine("Out of range");
            }
            
            return check;
        }
    }
}
