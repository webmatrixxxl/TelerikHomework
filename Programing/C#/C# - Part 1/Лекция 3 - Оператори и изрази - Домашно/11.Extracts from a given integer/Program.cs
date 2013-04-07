using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Extracts_from_a_given_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 35;
            int p = 2;
            int mask = (n >> p)%2;
            Console.WriteLine("Bit at position {0} is: {1}", p, mask);
        }
    }
}
