using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Find_All_Empty_Areas
{
    class Program
    {
        static char[,] lab = 
        {
            {' ', ' ', ' ', '*', ' ', ' ', ' '},
            {'*', '*', ' ', '*', ' ', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
            {' ', '*', '*', '*', '*', '*', ' '},
            {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };

        static Stack<Position> path = new Stack<Position>();

        static bool InRange(int row, int col)
        {
            bool rowInRange = row >= 0 && row < lab.GetLength(0);
            bool colInRange = col >= 0 && col < lab.GetLength(1);
            return rowInRange && colInRange;
        }

        static void  FindPathToExit(int row, int col)
        {
            if (!InRange(row, col))
            {
                // We are out of the labyrinth -> can't find a path
                return;
            }
            
            if (lab[row, col] != ' ')
            {
                // The current cell is not free -> can't find a path
                return;
            }

            // Temporary mark the current cell as visited to avoid cycles
            lab[row, col] = 's';
            path.Push(new Position(row, col));

            // Invoke recursion the explore all possible directions
            FindPathToExit(row, col - 1); // left
            FindPathToExit(row - 1, col); // up
            FindPathToExit(row, col + 1); // right
            FindPathToExit(row + 1, col); // down

            // Mark back the current cell as free
            // Comment the below line to visit each cell at most once
        }

        private static void PrintPath(Stack<Position> path)
        {
            Console.WriteLine("Found the largest connected area of adjacent empty cells in a matrix: ");

            foreach (var cell in path)
            {
                Console.Write("({0},{1}) -> ", cell.positionX, cell.positionY);
            }

            Console.WriteLine();
        }

        static void Main()
        {
            FindPathToExit(0, 0);
            PrintPath(path);
        }
    }
}
