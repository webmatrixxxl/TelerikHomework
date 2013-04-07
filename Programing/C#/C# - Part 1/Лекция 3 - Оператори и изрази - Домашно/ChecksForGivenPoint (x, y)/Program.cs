using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecksForGivenPoint__x__y_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter \"x\" and \"y\" values if fit in circle K((1,1);3 and out of the rectangle R(top=1, left=-1, width=6, height=2)");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            int rCirc = 3;
            int xCirc =1;
            int yCirc = 1;
            bool checkCirc = (x - xCirc) * (x - xCirc) + (y - yCirc) * (y - yCirc) <= rCirc*rCirc;
            bool checkRec = (x >= -1) && (y <= 1) && (x <= 5) && (y >= -1); 
            Console.WriteLine(checkCirc ? "The Point fits in the Circle" : "The point is outside the Circle");
            Console.WriteLine(checkRec ? "The Point is in the Rectengle" : "The point is out of Rectengle");



            //Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
            //and out of the rectangle R(top=1, left=-1, width=6, height=2).

        }
    }
}
