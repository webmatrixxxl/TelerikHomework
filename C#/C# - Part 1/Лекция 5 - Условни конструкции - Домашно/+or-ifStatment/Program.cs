using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _or_ifStatment
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
            if (f < 0 || s < 0 || t < 0)
            {
                if (f>0 & s>0 && t<0)
                {
                    Console.WriteLine("-");
                }
                else if (f<0 && s<0 && t<0)
                {
                    Console.WriteLine("-");
                }
                else if (f < 0 && s < 0 && t > 0)
                {
                    Console.WriteLine("+");
                }

                else if(f<0 && s>0 &&t>0)
                {
                    Console.WriteLine("-");
                }
                else if (f < 0 && s > 0 && t < 0)
                {
                    Console.WriteLine("+");
                }
                else if (f < 0 && s < 0 && t > 0)
                {
                    Console.WriteLine("-");
                }
                else if (f > 0 && s < 0 && t < 0)
                {
                    Console.WriteLine("+");
                }



            }
            else
            {
                Console.WriteLine("+");

            }
        }
    }
}
