using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).


namespace _15.AllPrimeNumbersInRange
{
    class Program
    {
        class SieveOfEratosthenes
        {
            static void Main()
            {
                bool[] arrayNums = new bool[10000000];
                for (int i = 2; i < Math.Sqrt(arrayNums.Length); i++)
                {
                    if (arrayNums[i] == false)
                    {
                        for (int c = i * i; c < arrayNums.Length; c = c + i)
                        {
                            arrayNums[c] = true;
                        }
                    }
                }
                for (int i = 2; i < arrayNums.Length; i++)
                {
                    if (arrayNums[i] == false)
                    {
                        Console.Write("{0} ", i);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
