using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.RemoveAllOddNumsFromList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = AddSequenceToList();
            List<int> oddList = FindOddNumbers(list);

            foreach (var item in oddList)
            {
                Console.WriteLine(item);
            }
        }

        private static List<int> FindOddNumbers(List<int> list)
        {
            List<int> oddList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                bool isOdd = true;
                double numSqrt = Math.Sqrt(list[i]);

                for (int div = 2; div <= numSqrt; div++)
                {
                    if (list[i] % div == 0)
                    {
                        isOdd = false;
                        break;
                    }
                }

                if (isOdd && list[i] != 2)
                {
                    oddList.Add(list[i]);
                }
            }

            return oddList;
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