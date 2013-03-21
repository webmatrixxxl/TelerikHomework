using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidAreaCalcolator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please ENTER a,b and h parametar of your trapezoid: ");
            Console.WriteLine("Please ENTER a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please ENTER b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Please ENTER h:");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Area of the trapezoid is: S={0}",((a+b)*h)/2);
        }
    }
}
