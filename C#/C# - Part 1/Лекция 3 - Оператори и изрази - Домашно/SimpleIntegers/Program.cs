using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plz ENTER integer 1<int<100 to check if it is PRIME or not: ");
            int num = int.Parse(Console.ReadLine());

            bool a = ((num == 2) || (num == 3) || (num == 5) || (num == 7) || (num % 2 > 0) && (num % 3 > 0) && (num % 5 > 0) && (num % 7 > 0));

            Console.WriteLine(a ? "Prime" : "NOT Prime");
        }
    }
}
