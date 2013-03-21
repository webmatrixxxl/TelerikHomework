using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindGratestFrom5Given
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
            Console.Write("Write fort integer ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Write fift integer ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Write sixt integer ");
            int c = int.Parse(Console.ReadLine());
            if (f > s && f > t && f > a && f > b && f > c)
            {
                Console.WriteLine("FIRST ONE is the biggest");
            }
            else if (s > f && s > t && s > a && s > b && s > c)
            {
                Console.WriteLine("SECOND ONE is the biggest");
            }
            else if (t > s && t > f && t > a && t > b && t > c)
            {
                Console.WriteLine("THIRD ONE is the biggest");
            }
            else if (a > s && a > f && a > b && a > c && a > t)
            {
                Console.WriteLine("FORTH ONE is the biggest");
            }
            else if (b > s && b > f && b > t && b > a && b > c)
            {
                Console.WriteLine("FIFT ONE is the biggest");
            }
            else if (c> s && c > f && c > a && c > b && c > t)
            {
                Console.WriteLine("SIXT ONE is the biggest");
            }
            else
            {
                Console.WriteLine("Nothing is bigger.");
            }
        }
    }
}
