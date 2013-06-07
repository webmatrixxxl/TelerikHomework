using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OccursNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<uint> list = AddSequenceToList();

            int[] listOfOccursNumbers = CountOccursNumbersInArray(list);

            for (int i = 0; i < listOfOccursNumbers.Length; i++)
            {
                if (listOfOccursNumbers[i] != 0)
                {
                    Console.WriteLine("{0} -> {1} times", i, listOfOccursNumbers[i]);
                }
            }
        }
  
        private static int[] CountOccursNumbersInArray(List<uint> list)
        {
            int[] array = new int[1000];

            for (int i = 0; i < list.Count; i++)
            {
                array[list[i]]++;
            }

            return array;
        }

        private static List<uint> AddSequenceToList()
        {
            Console.WriteLine("Enter members of sequence: ");

            List<uint> list = new List<uint>();
            uint parsedInput;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                if (!uint.TryParse(input, out parsedInput))
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
