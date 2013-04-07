using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcolateCirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please ENTER circle radius r=");
            int r = int.Parse(Console.ReadLine());
            double c = 2 * 3.14 * r;
            double s = 3.14 * r * r;
            Console.WriteLine("Circle Area is: {0} \nCircle Perimeter is: {1}",s,c);
        }
    }
}
