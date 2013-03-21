using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First10MembersOfSequance
{
    class First10MembersOfSequance
    {
        static void Main(string[] args)
        {
            int start = 1, switcher = -1;
            for (int i = 1; i <= 10; i++)
            {
                switcher = switcher * -1;
                Console.WriteLine((start + i) * switcher);
            }
        }
    }
}
