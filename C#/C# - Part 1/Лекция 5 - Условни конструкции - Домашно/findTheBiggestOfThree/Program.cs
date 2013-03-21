using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findTheBiggestOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write first integer ");
            int f = int.Parse(Console.ReadLine());
            Console.Write("Write second integer ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Write third integer ");
            int t = int.Parse(Console.ReadLine());
            if (f > s && f > t)
            {
                Console.WriteLine("FIRST ONE is the biggest");
            }
            else if (s > f && s > t)
            {
                Console.WriteLine("SECOND ONE is the biggest");
            }
            else if (t > s && t > f)
            {
                Console.WriteLine("THIRD ONE is the biggest");
            }
            else
            {
                Console.WriteLine("Nothing is bigger.");
            }
        }
    }
}
