using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints from given array of integers all
//numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda 
//expressions. Rewrite the same with LINQ.


namespace _06.FindDivisibleBy7and3LambdaAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4];
            array[0] = 21;
            array[1] = 1;
            array[2] = 2;
            array[3] = 3;

            var findWithLambda = Array.FindAll(array, x => (x % 3 == 0) && (x % 7 == 0));

            foreach (var item in findWithLambda)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var findWithLINQ = from num in array where num % 3 == 0 && num % 7 == 0 select num;

            foreach (var item in findWithLINQ)
            {
                Console.WriteLine(item);
            }

        }
    }
}
