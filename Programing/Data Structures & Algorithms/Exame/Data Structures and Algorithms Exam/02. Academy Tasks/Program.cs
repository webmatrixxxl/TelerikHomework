using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Academy_Tasks
{
    class Program
    {
        static List<int> tasks = new List<int>();
        static int variety;
        static int maxIndex;
        static int bestSolution;

        static void Main(string[] args)
        {
            // 1, 2, 3, 4, 5
            // 3
            string taskAsStringLine = Console.ReadLine();
            var tasksAsString = taskAsStringLine.Split(new char[] { ',', ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var taskAsString in tasksAsString)
            {
                tasks.Add(int.Parse(taskAsString));
            }

            variety = int.Parse(Console.ReadLine());
            bestSolution = tasks.Count;

            int currentMin = tasks[0];
            int currentMax = tasks[0];
            maxIndex = -1;

            for (int i = 0; i < tasks.Count; i++)
            {
                currentMin = Math.Min(currentMin, tasks[i]);
                currentMax = Math.Max(currentMax, tasks[i]);

                if (currentMax - currentMin >= variety)
                {
                    maxIndex = i;
                    break;
                }
            }

            if (maxIndex == -1)
            {
                Console.WriteLine(tasks.Count);
                return;
            }

            Slove(0, 1, tasks[0], tasks[0]);

            Console.WriteLine(bestSolution);
        }


        static void Slove(int currentIndex, int taskSloved, int currentMin, int currentMax)
        {
            if (currentMax - currentMin >= variety)
            {
                bestSolution = Math.Min(bestSolution, taskSloved);
                return;
            }

            if (currentIndex >= maxIndex)
            {
                return;
            }

            for (int i = 2; i >= 1; i--)
            {
                if (currentIndex + i < tasks.Count)
                {
                    Slove(currentIndex + i, taskSloved + 1,
                           Math.Min(currentMin, tasks[currentIndex + i]),
                           Math.Max(currentMax, tasks[currentIndex + i]));

                    if (bestSolution != tasks.Count)
                    {
                        return;
                    }
                }
            }
        }
    }
}
