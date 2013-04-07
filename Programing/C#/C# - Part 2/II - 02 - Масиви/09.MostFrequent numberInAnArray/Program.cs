using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the most frequent number in an array. Example:
//    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


namespace _09.MostFrequent_numberInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int counter;
            int arraybuff = 0;
            int counterbuff = 0;

            int[] array = new int[13] { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            for (int i = 0; i < array.Length; i++)
            {
                counter = 0;
                for (int c = 0; c < array.Length; c++)
                {
                    if (array[i] == array[c])
                    {
                        counter++;
                        if (counter>counterbuff)
                        {
                            arraybuff = array[c];
                            counterbuff = counter;

                        }
                    }
                  
                }

            }
            
            Console.WriteLine(arraybuff);
        }
    }
}
