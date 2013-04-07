using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a number and prints it as a decimal number, 
//hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.


namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,0}", num); // Decimal

            Console.WriteLine("{0,0:X}", num); // Hexadecimal

            Console.WriteLine("{0,0:P}", num); // Percentage

            Console.WriteLine("{0,0:E}", num); // Scientific notation
        }
    }
}
