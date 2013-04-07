using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.


namespace _04.TriangleArea
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine(AreaAltitude(a: 3, h: 4));
            Console.WriteLine(AreaHerons(a: 3, b: 4, c: 5));
            Console.WriteLine(AreaAngle(a: 3, b: 4, alpha: 90));
        }

        static double AreaAltitude(double a, double h)
        {
            return (a * h) / 2;
        }

        static double AreaHerons(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }


        static double AreaAngle(double a, double b, double alpha)
        {
            return (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;
        }

    }
}
