//Write a program that allocates array of 20 integers and initializes
//each element by its index multiplied by 5. Print the obtained array
//on the console.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестър_II___Лекция_2___Месиви
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[19]; //Initialize array with size of 20 integers (0-19)
            for (int i = 0; i < array.Length; i++) //Each element of array take value of i * 5 the result
            {                                      //is written to the console and i is incremented by
                array[i] = i * 5;                  // 1 during each iteration of the loop.
                Console.WriteLine(array[i]);
            }
        }
    }
}
