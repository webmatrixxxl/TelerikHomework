using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace III___01___Дефинране_на_класове
{
    class GenericList<T>
    {
        //<fields>
        public T[] array { get; set; }
        private int count = 0;
        private int arraySize;
        //</fields>

        //<constructors>
        public GenericList()
        {
            this.arraySize = 4;
            array = new T[arraySize];


        }
        //</constructors>

        //<properties>

        //</properties>

        //<methods>
        public void Insert(T value, int index)
        {
            if (index >= array.Length)
            {
                throw new IndexOutOfRangeException("Index must be in the range 0 - 3");
            }

            this.array[index] = value;
            count++;
            if (count == array.Length)
            {
                T[] arrayBuffer = new T[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    arrayBuffer[i] = this.array[i];
                }
                array = arrayBuffer;
            }
        }

        public void RemoveElement(T value, int index)
        {
            if (index >= array.Length)
            {
                throw new IndexOutOfRangeException("Index must be in the range 0 - 3");
            }
            T[] arraybuffer = array;

            for (int i = 0, c = 0; i < array.Length + 1; i++, c++)
            {
                if (i == index)
                {
                    c++;
                }
                arraybuffer[i] = this.array[c];
            }
            count--;
            this.array = arraybuffer;
        }
        public void AddElement(T value)
        {
            T[] arraybuffer = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                arraybuffer[i] = array[i];
            }
            arraybuffer[arraybuffer.Length - 1] = value;
            array = arraybuffer;
            count++;
        }
        public void ClearArray()
        {
            Array.Clear(array, 0, array.Length);
            count = 0;
        }
        public T Access(int index)
        {
            return array[index];
        }
        public T Find(T value)
        {
            int index = Array.IndexOf(array, value);
            Console.WriteLine(index + "opa");
            if (index < 0)
            {
                throw new IndexOutOfRangeException("ELEMENT IS NOT FOUND IN LIST");
            }
            return array[index];
        }

        public T Min()
        {
            T[] sortedArray = array;
            Array.Sort(sortedArray);
             return sortedArray[0];
        }
        public T Max()
        {
            T[] sortedArray = array;
            Array.Sort(sortedArray);
            return sortedArray[sortedArray.Length-1];
        }
      
      
        //</methods>

    }
}
