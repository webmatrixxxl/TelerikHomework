using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a 1 matrix of size N x M and
//finds in it the square 3 x 3 that has maximal sum of its elements.


namespace MaxPlatform3x3
{
    class Program
    {
        static void Main()
        {

            // Declare and initialize the matrix

            int[,] matrix = {

        { 0, 2, 4, 0, 9, 5 },

        { 10, 10, 8, 9, 0, 9 },

        { 10, 9, 9, 9, 9, 9 },

        { 10, 10, 10, 9, 9, 9 }

            };

            // Find the maximal sum platform of size 2 x 2

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            int area = 3;
            int sum = 0;
            for (int row = 0; row <= matrix.GetLength(0) - area; row++)
            {

                for (int col = 0; col <= matrix.GetLength(1) - area; col++)
                {

                    for (int r = row; r < row + area; r++)
                    {
                        for (int c = col; c < col + area; c++)
                        {
                            sum = sum + matrix[r, c];

                        }

                    }
                    if (sum > bestSum)
                    {

                        bestSum = sum;

                        bestRow = row;

                        bestCol = col;

                    }

                    sum = 0;


                }

            }



            // Print the result

            Console.WriteLine("The best platform is:");
            for (int r = bestRow; r < bestRow + area; r++)
            {
                for (int c = bestCol; c < bestCol + area; c++)
                {
                    Console.Write("{0,4}", matrix[r, c]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("The maximal sum is: {0}", bestSum);

        }
    }
}
