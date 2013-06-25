using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ImplementPriorityQueue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PriorityQueue<int> myHeap = new PriorityQueue<int>(2);
            myHeap.Enqueue(0);
            myHeap.Enqueue(1);
            myHeap.Enqueue(2);
            myHeap.Enqueue(3);
            myHeap.Dequeue();
            myHeap.Enqueue(3);
            myHeap.Enqueue(5);

            Console.WriteLine(myHeap.Dequeue());

            myHeap.Print();
            myHeap.Enqueue(2);
            myHeap.Print();
        }
    }
}
