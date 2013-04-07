using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Catalan
{
    class Program
    {
        static void Main(string[] args)
        {


            int num;
            string inputN=null;
            while (!int.TryParse(inputN, out num) || num < 0)
            {
                Console.Write("Enter N to fit N>=0: ");
                inputN = Console.ReadLine();

            }
            BigInteger n;
            BigInteger n2;
            BigInteger n3;
            n = n2 = n3 = 1;
            BigInteger sum;
            for (int i = 1; i <= num*2; i++)
            {

                n *= i;
            }
            for (int i = 1; i <= num +1; i++)
            {
               
                n2 *= i;
            }
            for (int i = 1; i <= num; i++)
            {
               
                n3 *= i;
            }
            sum = n / (n2 * n3);
            Console.WriteLine(sum);

        }
    }
}
