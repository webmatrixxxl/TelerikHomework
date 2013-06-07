using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _10.ShortestSequence
{
    static class Program
    {
        static IList<T> Clone<T>(this IList<T> list)
            where T : struct
        {
            return list.Select(item => item).ToList();
        }

        static Func<int, int>[] operations =
        {
            x => x + 1,
            x => x + 2,
            x => x * 2,
        };

        static void Main()
        {
            int start = 5;
            int end = 250;

            Debug.Assert(end > start);

            var results = new List<IList<int>>();

            var visited = new HashSet<int>();
            var sequences = new Queue<IList<int>>();

            visited.Add(start);
            sequences.Enqueue(new int[] { start });

            int level = 1;

            while (sequences.Count != 0)
            {
                var nextSequences = new Queue<IList<int>>();
                var currentVisited = new HashSet<int>();

                level++;

                while (sequences.Count != 0)
                {
                    var currentSequence = sequences.Dequeue();

                    foreach (var operation in operations)
                    {
                        int currentNumber = operation(currentSequence.Last());

                        if (currentNumber > end || visited.Contains(currentNumber))
                        {
                            continue;
                        }

                        var nextSequence = currentSequence.Clone();
                        nextSequence.Add(currentNumber);

                        currentVisited.Add(currentNumber);
                        nextSequences.Enqueue(nextSequence);

                        if (currentNumber == end)
                        {
                            results.Add(nextSequence);
                        }
                    }
                }

                visited.UnionWith(currentVisited);

                if (results.Count != 0)
                {
                    nextSequences.Clear();
                }

                sequences = nextSequences;
            }

            Console.WriteLine("Sequence length: {0}", level);

            foreach (var sequence in results)
            {
                Console.WriteLine(string.Join(" ", sequence));
            }
        }
    }
}