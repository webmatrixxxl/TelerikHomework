using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ExchangeBitPositions
{
    class Program
    {
        static void Main(string[] args)
        {

            uint num = 58;
            uint mast = num << 21;
            uint mast2 = num >>21;
            uint a = mast | mast2;
            Console.WriteLine(a);

        }
    }
}
