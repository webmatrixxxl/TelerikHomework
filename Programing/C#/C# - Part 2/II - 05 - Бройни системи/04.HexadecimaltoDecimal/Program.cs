using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to their decimal representation.


namespace _04.HexadecimaltoDecimal
{
    class Program
    {
        static void Main()
        {
            string color = "FFFFFF";
            Console.WriteLine(ConvertToDecimal(color));
        }
        private static int ConvertToDecimal(string b)
        {
            int result = 0;
            for (int i = b.Length - 1, p = 0; i >= 0; i--, p++)
            {
                result += ((b[i] - '0') < 10 ? (b[i] - '0') : (b[i] - 55)) * (int)Math.Pow(16, p);
            }
            return result;
        }
    }
}
