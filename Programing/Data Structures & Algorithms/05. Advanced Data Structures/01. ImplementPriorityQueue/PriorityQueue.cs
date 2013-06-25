using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ImplementPriorityQueue
{

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private const int DefaultCapacity = 8;
        private int capacity;
        private T[] array;
        private int size;

        public PriorityQueue()
        {
            this.capacity = DefaultCapacity;
            this.array = new T[this.capacity];
            this.size = 0;
        }

        public PriorityQueue(int size)
        {
            this.array = new T[size];
            this.size = 0;
            this.capacity = size;
        }

        public int Count
        {
            get
            {
                return this.size;
            }
        }

        public void Enqueue(T element)
        {
            if (this.size >= this.capacity)
            {
                this.Resize();
            }

            this.array[this.size] = element;
            this.SiftUp();
            this.size++;
        }

        public T Dequeue()
        {
            if (this.size <= 0)
            {
                throw new ArgumentOutOfRangeException("size", "Cannot dequeue from empty priority queue!");
            }

            T highestPriorityElement = this.array[0];
            this.array[0] = this.array[this.size - 1];
            this.size--;
            this.SiftDown();
            return highestPriorityElement;
        }

        public T Peek()
        {
            if (this.size <= 0)
            {
                throw new ArgumentException("Cannot peek into empty priority queue!");
            }

            return this.array[0];
        }

        public void Print()
        {
            Console.WriteLine(string.Join(", ", this.array.Take(this.size)));
        }

        private void Resize()
        {
            this.capacity = this.capacity * 2;
            T[] newArray = new T[this.capacity];
            for (int i = 0; i < this.size; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }

        private void SiftUp()
        {
            int currentPosition = this.size;
            int parentPosition = (currentPosition - 1) / 2;
            while (currentPosition > 0)
            {
                if (this.array[currentPosition].CompareTo(this.array[parentPosition]) > 0)
                {
                    this.Swap(ref this.array[currentPosition], ref this.array[parentPosition]);
                }
                else
                {
                    return;
                }

                currentPosition = parentPosition;
                parentPosition = (currentPosition - 1) / 2;
            }
        }

        private void SiftDown()
        {
            int currentPosition = 0;
            int leftChildPosition = (currentPosition * 2) + 1;
            int rightChildPosition = leftChildPosition + 1;

            while (leftChildPosition < this.size)
            {
                int index = leftChildPosition;

                if (rightChildPosition < this.size &&
                    this.array[leftChildPosition].CompareTo(this.array[rightChildPosition]) < 0)
                {
                    index = rightChildPosition;
                }

                if (this.array[currentPosition].CompareTo(this.array[index]) > 0)
                {
                    return;
                }

                this.Swap(ref this.array[currentPosition], ref this.array[index]);

                leftChildPosition = (index * 2) + 1;
                rightChildPosition = leftChildPosition + 1;
                currentPosition = index;
            }
        }

        private void Swap(ref T first, ref T second)
        {
            T oldValue = first;
            first = second;
            second = oldValue;
        }
    }
}