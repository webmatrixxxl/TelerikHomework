using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SortListSequenceIncreasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<uint> list = AddSequenceToList();
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
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