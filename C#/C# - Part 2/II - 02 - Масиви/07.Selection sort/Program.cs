using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            /* a[0] to a[n-1] is the array to sort */
            int[] a = new int[5] { 64, 25, 12, 22, 11 };
            for (int i = 0; i < a.Length; i++)
            {
                for (int c = i; c < a.Length; c++)
                {
                    int min = i;
                    if (a[min]>a[c])
                    {
                        min = c;
                    }
                    int temp = a[i]; // Copy the first position's element
                    a[i] = a[min]; // Assign to the second element
                    a[min] = temp; // Assign to the first element
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
    }
}
