using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //We are given a matrix of strings of size N x M. Sequences in the matrix we define
    //as sets of several neighbor elements located on the same line, column or diagonal.
    //Write a program that finds the longest sequence of equal strings in the matrix.

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] matrix = 
            { 
                { "ha", "s", "ha", "ha" },
                { "fo", "ha", "hi", "xx" }, 
                { "xxx", "ho", "ha", "ha" },
                { "x", "ho", "hs", "ha" },
            };
            PrintMatrix(matrix);
            Console.WriteLine(FindLongestSeq(matrix));

        }

        static int FindLongestSeq(string[,] matrix)
        {
            int counterZ = 1;
            int counterX = 1;
            int counterY = 1;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        counterX++;
                    }
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        counterY++;
                    }
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counterZ++;
                    }
                }
            }

            return counterZ > counterX ? (counterZ > counterY ? counterZ : counterY) : (counterX > counterY ? counterX : counterY);
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,8}", matrix[row, col]);

                }
                Console.WriteLine();

            }
        }
    }
}
