using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file containing a square matrix of numbers and finds in the
//matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input
//file contains the size of matrix N. Each of the next N lines contain N numbers separated by
//space. The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2

namespace _05.ReadSquaerMatrixFromFileAndFindMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader("../../text1.txt"))
            {
                int n = int.Parse(input.ReadLine());
                int[,] matrix = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    string[] numbers = input.ReadLine().Split(' ');

                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = int.Parse(numbers[j]);
                    }
                }

                using (StreamWriter input2 = new StreamWriter("../../text2.txt"))
                {
                    int bestSum = int.MinValue;
                    int bestRow = 0;
                    int bestCol = 0;

                    int area = 2;
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

                    input2.WriteLine(bestSum);

                }
            }
        }
    }
}
