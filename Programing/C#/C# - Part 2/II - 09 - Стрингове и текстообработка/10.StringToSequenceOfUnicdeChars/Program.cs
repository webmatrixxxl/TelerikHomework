using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings. 
//        Sample input:Hi!

//        Expected output:
//        \u0048\u0069\u0021



namespace _10.StringToSequenceOfUnicdeChars
{
    class Program
    {
        static void Main()
        {
            string str = "Hi!";

            foreach (var symbol in str)
            {
                Console.Write("\\u{0:X4}", (int)symbol);
            }
        }
    }
}
