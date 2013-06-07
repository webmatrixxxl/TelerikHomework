using System;
using System.Linq;

namespace _13.ImplementDynamicQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedQueue<char> queue = new LinkedQueue<char>();

            for (int i = 65; i < 80; i++)
            {
                queue.Push((char)i);
            }

            Console.WriteLine(queue.Peek());
            Console.WriteLine();

            for (int i = 0; i < queue.Count; i++)
            {
                Console.WriteLine(queue.Pop());
            }

            Console.WriteLine();
            queue.Push('A');
            Console.WriteLine(queue.Pop());
            // throws exception when queue is empty
            // Console.WriteLine(queue.Pop());

        }
    }
}
