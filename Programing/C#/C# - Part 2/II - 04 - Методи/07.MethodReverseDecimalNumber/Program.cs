using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that reverses the digits of given decimal number. Example: 256  652


namespace _07.MethodReverseDecimalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();// For my local to must use ","
            Console.WriteLine(ReverseWithString(num));

           
        }

      
        static decimal ReverseWithString(string num)
        {
            string numRev = null;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                numRev += num[i];
            }
            
            return decimal.Parse(numRev);
        }


    }
}
