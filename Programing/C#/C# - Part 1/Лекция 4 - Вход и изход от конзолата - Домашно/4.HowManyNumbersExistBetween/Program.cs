using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HowManyNumbersExistBetween
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas ENTER tow integers.\n");
            Console.Write("Enter first one:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\nEnter second one:");
            int b = int.Parse(Console.ReadLine());
            int counter=0;

            for (int i = a; i < b; )
            {
                if (i++ % 5 == 0)
                {
                    counter++;
                }

            }
            Console.WriteLine("\n{0} numbers form interval {1} to {2} can be devided to 5 wtih reminder 0",counter,a,b);
            
        }
    }
}
