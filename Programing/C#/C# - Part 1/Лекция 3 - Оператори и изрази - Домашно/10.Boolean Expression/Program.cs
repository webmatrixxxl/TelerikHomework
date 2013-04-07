using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Boolean_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 5;
            int p = 1;
            int mask = (v>>p) % 2;
            Console.WriteLine("Bit at position {0} is: {1}",p,mask);
        }
    }
}
