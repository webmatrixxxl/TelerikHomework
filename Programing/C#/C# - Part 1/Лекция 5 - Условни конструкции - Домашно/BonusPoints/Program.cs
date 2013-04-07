using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write integer points from 1-9 ");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Bonus points - x10. Total points: {0}", a * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Bonus points - x100. Total points: {0}", a * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Bonus points - x1000. Total points: {0}", a * 1000);
                    break;
                default:
                    Console.WriteLine("Entered ponts are not in interval 1-9");
                    break;

            }


        }
    }
}
