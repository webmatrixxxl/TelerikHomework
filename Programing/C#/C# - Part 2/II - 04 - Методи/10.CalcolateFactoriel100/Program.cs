using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program to calculate n! for each n in the range [1..100].
//Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 


namespace _10.CalcolateFactoriel100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factoriel(100)); 
        }
        static BigInteger Factoriel(int n)
        {
            if (n==0)
            {
                return 1;
            }
            else
            {
                return n * Factoriel(n - 1);
            }
        }
    }
}
