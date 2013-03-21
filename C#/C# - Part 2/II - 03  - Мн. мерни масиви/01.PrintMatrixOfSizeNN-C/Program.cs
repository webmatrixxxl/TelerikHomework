using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintMatrixOfSizeNN_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            int[,] matrix = new int[n, n];
            int counter = 1;

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matrix[n - i + j - 1, j] = counter++;
                    
                }
            }
            for (int i = n - 2; i >= 0; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    matrix[i - j, n - j - 1] = counter++;
                    Console.Write(matrix[i - j, n - j - 1] + " ");
                }
            }
        }
    }
}
