using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            float a1, b1, c1;
            Console.WriteLine("This programs sloves quadratic equation ax2+bx+c=0");
            Console.Write("Plz enter \"a\" coefficient > 0. a=");
            string a = Console.ReadLine();

            bool checkA = float.TryParse(a, out a1) && a1 != 0;
            while (checkA == false)
            {
                Console.Write("Plese enter again \"a\", but this time numeric different form 0.  a=");
                a = Console.ReadLine();
                checkA = float.TryParse(a, out a1) && a1 != 0;
            }
            Console.Write("Plz enter \"b\" coefficient. b=");
            string b = Console.ReadLine();
            bool checkB = float.TryParse(b, out b1);
            while (checkB == false)
            {
                Console.Write("Plese enter again \"b\", but this time numeric.  b=");
                b = Console.ReadLine();
                checkB = float.TryParse(b, out b1);
            }
            Console.Write("Plz enter \"c\" coefficient. c=");
            string c = Console.ReadLine();
            bool checkC = float.TryParse(c, out c1);
            while (checkC == false)
            {
                Console.Write("Plese enter again \"c\", but this timenumeric.  c=");
                c = Console.ReadLine();
                checkC = float.TryParse(c, out c1);
            }

            //ax2+bx+c=0
            float D = b1 * b1 - 4 * a1 * c1;
            if (D < 0)
            {
                Console.WriteLine("The qudratic equation have no real roots");

            }
            else if (D == 0)
            {
                Console.WriteLine("X = {0}", b1 / 2 * a1);
            }
            else if (D > 0)
            {
                Console.WriteLine("x1 = {0}; x2={1}", -b1 + Math.Sqrt(D) / 2 * a1, -b1 - Math.Sqrt(D) / 2 * a1);
            }
        }
    }
}