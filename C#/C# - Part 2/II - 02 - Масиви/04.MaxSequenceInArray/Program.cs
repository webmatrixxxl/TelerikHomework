using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.


namespace _04.MaxSequenceInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0; // Брояч на поредните еднакви числа.
            int counterbuff = 0; // След като стигнем поредно число което е различно от предходните counter се нулира, а counterbuff пази наговата стойност.
            int maxSeq = 0; // Пази стойността на последния член от най-дългата редицата с еднакви членове.
            int keepCount = 0; // Пази броя от членове на най-дългата редицата с еднакви членове.
            int[] array = new int[10] { 2, 1, 2, 1, 2, 1, 2, 1, 0, 2 };
            for (int i = 0; i < array.Length; i++)
            {

                if (i < array.Length - 1)
                {


                    if (array[i] == array[i + 1])
                    {

                        counter++;

                    }
                    else if (0 == array[i] && array[i + 1] != 0)
                    {

                        counter++;
                    }

                    if (counter > counterbuff)
                    {
                        maxSeq = array[i];
                        keepCount = counter;
                    }
                    if (array[i + 1] != array[i] && counter != 0)
                    {
                        counterbuff = counter;
                        counter = 0;
                    }
                }


            }
            for (int i = 0; i <= keepCount; i++)
            {

                Console.Write(maxSeq);

            }
            Console.WriteLine();
        }
    }
}
