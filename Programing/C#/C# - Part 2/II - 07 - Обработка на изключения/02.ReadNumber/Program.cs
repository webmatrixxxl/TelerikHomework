using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReadNumber
{
    class Program
    {

        static void Main()
        {
            int min = 1, max = 100;
            List<int> arr = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                arr.Add(ReadNumber(min, max));
            }
        }

        static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());

            if (!(start < n && n < end))
            {
                throw new ArgumentOutOfRangeException();
            }

            return n;
        }
    }
}
