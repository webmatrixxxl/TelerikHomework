using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

namespace II___C_sharp___Л._3___Мн.мерни_масиви
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
                for (int col = 0; col < n; col++)
                {

                    matrix[row, col] = row + count;
                    count += n;
                    //Console.WriteLine(matrix[col, row]);
                    //matrix[col, row] = count++;
                    Console.Write("{0, 4}", matrix[row, col]);

                }
                if (row / n == 0)
                {
                    count = 1;
                    Console.WriteLine();

                }
                Console.WriteLine();
            }

        }

    }
}
