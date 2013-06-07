using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.TheMajorant
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = AddSequenceToList();
            List<int> longestSequenceOfEquals = FindLongestSubSequenceOfEquals(list);

            FindMajorant(longestSequenceOfEquals, list);
        }
  
        private static void FindMajorant(List<int> longestSequenceOfEquals, List<int> list)
        {
            if (longestSequenceOfEquals.Count >= list.Count / 2 + 1)
            {
                Console.WriteLine(longestSequenceOfEquals[0]);
            }
            else
            {
                Console.WriteLine("The mahorant does not exists!");
            }
        }

        public static List<int> FindLongestSubSequenceOfEquals(List<int> list)
        {
            int equalsCount = 1;
            int bestCount = 0;
            int bestSeq = 0;
            List<int> newList = new List<int>();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    equalsCount++;
                }
                else
                {
                    equalsCount = 1;
                }

                if (bestCount < equalsCount)
                {
                    bestCount = equalsCount;
                    bestSeq = list[i - 1];
                }
            }
            for (int i = 0; i < bestCount; i++)
            {
                newList.Add(bestSeq);
            }

            return newList;
        }


        private static List<int> AddSequenceToList()
        {
            Console.WriteLine("Enter members of sequence: ");

            List<int> list = new List<int>();
            int parsedInput;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                if (!int.TryParse(input, out parsedInput))
                {
                    Console.WriteLine("Enter positive integer!");
                }
                else
                {
                    list.Add(parsedInput);
                }
            }

            return list;
        }
    }
}
