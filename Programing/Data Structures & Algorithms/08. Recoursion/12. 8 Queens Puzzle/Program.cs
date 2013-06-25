using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._8_Queens_Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 8;
            SloveQueensProblem(new bool[size, size], new int[size, size], 0);
            Console.WriteLine(count);
        }

        static int count;

        static void SloveQueensProblem(bool[,] chessBord, int[,] occupied, int columIndex)
        {
            if (columIndex == chessBord.GetLength(0))
            {
                count++;
                return;
            }

            for (int rowIndex = 0; rowIndex < chessBord.GetLength(0); rowIndex++)
            {
                if (occupied[rowIndex, columIndex] == 0)
                {
                    chessBord[rowIndex, columIndex] = true;
                    MarkOccupied(occupied, +1, rowIndex, columIndex);
                    SloveQueensProblem(chessBord, occupied, columIndex + 1);
                    chessBord[rowIndex, columIndex] = false;
                    MarkOccupied(occupied, -1, rowIndex, columIndex);
                }
            }
        }

        static void MarkOccupied(int[,] occupied, int value, int row, int column)
        {
            for (int i = 0; i < occupied.GetLength(0); i++)
            {
                occupied[i, column] += value;
                occupied[row, i] += value;

                if (column + i < occupied.GetLength(0)
                    && row + i < occupied.GetLength(0))
                {
                    occupied[row + i, column + i] += value;
                }

                if (column + i < occupied.GetLength(0)
                    && row - i >= 0)
                {
                    occupied[row - i, column + i] += value;
                }
            }
        }
    }
}
