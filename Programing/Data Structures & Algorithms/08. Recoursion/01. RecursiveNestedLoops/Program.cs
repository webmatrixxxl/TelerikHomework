using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.RecursiveNestedLoops
{
    class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;

        static void Main()
        {
            Console.Write("K = ");
            numberOfLoops = int.Parse(Console.ReadLine());

            Console.Write("N = ");
            numberOfIterations = int.Parse(Console.ReadLine());

            loops = new int[numberOfLoops];

            InitLoops();
            GemerateCombinations();

        }

        static void GemerateCombinations()
        {
            int currentPosition;

            while (true)
            {
                PrintLoops();
                currentPosition = numberOfLoops - 1;
                loops[currentPosition] = loops[currentPosition] + 1;

                while (loops[currentPosition] > numberOfIterations)
                {
                    loops[currentPosition] = 1;
                    currentPosition--;

                    if (currentPosition < 0)
                    {
                        return;
                    }

                    loops[currentPosition] = loops[currentPosition] + 1;
                }
            }
        }

        static void InitLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                loops[i] = 1;
            }

        }

        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }

            Console.WriteLine();
        }
    }
}