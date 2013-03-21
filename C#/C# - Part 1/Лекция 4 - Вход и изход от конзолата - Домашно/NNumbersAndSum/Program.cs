using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNumbersAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            Console.Write("Please ENTER n number of numbers to be sumed. n=");
            decimal n = decimal.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Pleas enter next number:");
                sum = decimal.Parse(Console.ReadLine()) + sum;
                
            }
            Console.WriteLine("The SUM of numbers is:{0}", sum);
        }
    }
}
