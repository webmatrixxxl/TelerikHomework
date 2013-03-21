using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;



namespace _06.NandXCalcolateSumFormula
{
    class Program
    {
        static void Main(string[] args)
        {

            //S = 1 + 1!/X + 2!/X2 + … + N!/X^N

            BigInteger S = 1;
            BigInteger x = 0;
            BigInteger N = 1;
            BigInteger c = 0;
            int n;
            string inputK = null, inputN = null;

            while (!int.TryParse(inputN, out n))
            {
                Console.Write("Enter N : ");
                inputN = Console.ReadLine();
                int.TryParse(inputN, out n);
            }

            while (!BigInteger.TryParse(inputK, out x))
            {
                Console.Write("Enter K: ");
                inputK = Console.ReadLine();
                BigInteger.TryParse(inputK, out x);

                c = x;
            }


            for (int i = 1; i <= n; i++)
            {
                N *= i;
                if (1 != i)
                {

                    x *= c;

                }
             
                S += N / x;
            }

            Console.WriteLine("S={0}", S);
        }
            
    }
}
