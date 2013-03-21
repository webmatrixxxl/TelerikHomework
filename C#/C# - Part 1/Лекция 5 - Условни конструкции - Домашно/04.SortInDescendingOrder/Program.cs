using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SortInDescendingOrder
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
            if (f > s && f> t)
            {
                if (s>t)
                {
                    Console.WriteLine("{0} {1} {2}", f, s, t);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", f, t, s);
                }
                
            }
            else if (s > f && s > t)
            {
                if (f > t)
                {
                    Console.WriteLine("{0} {1} {2}", s, f, t);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", s, t, f);
                }
            }
            else if (t > s && t > f)
            {
                if (f > s)
                {
                    Console.WriteLine("{0} {1} {2}", t, f, s);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", t, s, f);
                }
            }
           
        }
    }
}
