using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ReverceSequenceUsingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = AddSequenceToStack();
            stack.Reverse();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        private static Stack<int> AddSequenceToStack()
        {
            Console.WriteLine("Enter members of sequence: ");

            Stack<int> stack = new Stack<int>();
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
                    Console.WriteLine("Please enter integer number!");
                }
                else
                {
                    stack.Push(parsedInput);
                }
            }

            return stack;
        }
    }
}