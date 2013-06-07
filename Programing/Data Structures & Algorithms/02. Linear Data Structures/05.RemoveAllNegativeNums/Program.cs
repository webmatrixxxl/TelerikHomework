using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveAllNegativeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = AddSequenceToList();
            RemoveNegativeNumbers(list);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        private static void RemoveNegativeNumbers(List<int> list)
        {
            int listCount = list.Count;

            for (int i = 0; i < listCount; i++)
            {
                if (list[i] < 0)
                {
                    list.Remove(list[i]);
                    i--;
                    listCount--;
                }
            }
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