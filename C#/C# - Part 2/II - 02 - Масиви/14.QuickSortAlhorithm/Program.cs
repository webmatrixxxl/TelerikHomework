using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.QuickSortAlhorithm
{
    class Program
    {
        private static List<int> QuickSort(List<int> a, int left, int right)
        {
            int i = left;
            int j = right;
            double pivotValue = ((left + right) / 2);
            int x = a[Convert.ToInt32(pivotValue)];
            int w = 0;
            while (i <= j)
            {
                while (a[i] < x)
                {
                    i++;
                }
                while (x < a[j])
                {
                    j--;
                }
                if (i <= j)
                {
                    w = a[i];
                    a[i++] = a[j];
                    a[j--] = w;
                }
            }
            if (left < j)
            {
                QuickSort(a, left, j);
            }
            if (i < right)
            {
                QuickSort(a, i, right);
            }
            return a;
        }
        // Quicksort in C#
        static void Main(string[] args)
        {
            List<int> tempData = new List<int>();
            tempData.Add(4);
            tempData.Add(24);
            tempData.Add(1);
            tempData.Add(3);
            tempData.Add(5);
            List<int> newList = QuickSort(tempData, 0, tempData.Count - 1);
            for (int b = 0; b < newList.Count; b++)
            {
                Console.Write(newList[b]+ " ");
            }
            Console.WriteLine();
        }
    }
}
