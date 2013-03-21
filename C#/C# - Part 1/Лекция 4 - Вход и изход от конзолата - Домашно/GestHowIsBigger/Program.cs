using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestHowIsBigger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please ENTER two numbers and see what is bigger.");
            Console.Write("Please ENTER thre firest one. A=");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Please ENTER thre second one. B=");
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = Math.Max(a, b);
            Console.WriteLine("The greater number is: {0}",c);

        }
    }
}
