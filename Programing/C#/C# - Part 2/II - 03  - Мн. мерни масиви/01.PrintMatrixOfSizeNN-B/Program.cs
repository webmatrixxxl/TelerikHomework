using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintMatrixOfSizeNN_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int count = 1;
            for (int row = 0; row < n; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < n; col++)
                    {

                        matrix[col, row] = count++;


                        Console.Write("{0, 4}", matrix[row, col]);

                    }


                }
                else
                {
                    for (int col = n - 1; col >= 0; col--)
                    {

                        matrix[col, row] = count++;

                        Console.Write("{0, 4}", matrix[row, col]);

                    }
                }
                if (row / n == 0)
                {
                    
                    Console.WriteLine();

                }
                Console.WriteLine();
            }

        }
    }
}
