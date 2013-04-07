using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).


namespace _08.BinaryRepOf16BiysigntIntegr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a short integer number: ");
            short output;
            short.TryParse(Console.ReadLine(), out output);
            Console.Write("The binary representation of the number is: ");
            Console.WriteLine(Convert.ToString(output, 2));
        }
    }
}
