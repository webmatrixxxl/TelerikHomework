using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Linear_Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<uint> list = AddSequenceToList();
            var sum = list.Cast<uint>().Sum(num => num);
            var avarage = list.Cast<uint>().Average(num => num);

            Console.WriteLine("Sum of list element = {0}", sum);
            Console.WriteLine("Avarage of list element = {0}", avarage);
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