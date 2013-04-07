using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.
//* Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.).
//Use generic method (read in Internet about generic methods in C#).


namespace _13и14.MinMaxAvrgSumProductOfSet
{
    class Program
    {
         static long Fib(int n)
         {
             if (n <= 2)
             {
                 return 1;
             }
             return Fib(n-1) + Fib(n-2);
         }
	
    }
}
