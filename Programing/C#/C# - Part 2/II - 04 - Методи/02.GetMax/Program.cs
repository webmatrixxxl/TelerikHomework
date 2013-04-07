using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method GetMax() with two parameters that returns the bigger of two integers.
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


namespace _02.GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int paramA = int.Parse(Console.ReadLine());
            int paramB = int.Parse(Console.ReadLine());
            int paramC = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(GetMax(paramA, paramB), paramC));
        }
        static int GetMax(int paramA, int paramB)
        {
            int bigger = paramA > paramB ? paramA : paramB;
            return bigger;
        }
    }
}
