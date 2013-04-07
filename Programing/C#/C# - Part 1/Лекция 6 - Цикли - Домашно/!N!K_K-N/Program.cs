using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _N_K_K_N
{
    class Program
    {
        static void Main(string[] args)
        {
            //N!*K! / (K-N)! 

            Console.WriteLine("Enter N to fit 1<!N<!K :");
            string inputN = Console.ReadLine();
            uint k = 0;
            uint n = 0;
            uint.TryParse(inputN, out n);
                Console.WriteLine("Enter K to fit  1<!N<!K ");
            string  inputK = Console.ReadLine();
            while (!uint.TryParse(inputK, out k) || n > k)
            {
                Console.WriteLine("Enter K to fit  1<!N<!K ");
                inputK = Console.ReadLine();

            }
            BigInteger resultN = 1;
            BigInteger resultK = 1;
            BigInteger resultKN = k-n;
            for (BigInteger i = 1; i <= k; i++)
            {
                resultK *= i;

            }
            for (BigInteger i = 1; i <= n; i++)
            {
                resultN *= i;

            }
            for (BigInteger i = 1; i <= (k-n); i++)
            {
                resultKN *= i;

            }
            Console.WriteLine(resultN);
            Console.WriteLine(resultK);
            Console.WriteLine(resultKN);
        }
    }
}
