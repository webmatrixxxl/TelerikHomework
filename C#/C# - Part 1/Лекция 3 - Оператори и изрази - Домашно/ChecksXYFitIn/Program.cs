using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecksXYFitIn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter \"x\" and \"y\" values if fit in circle K(0;5)");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            bool check = (x * x) + (y * y) <= 25;
            Console.WriteLine("The Point A({1};{2}) fit in circle K: {0};",check,x,y);
        }
    }
}
