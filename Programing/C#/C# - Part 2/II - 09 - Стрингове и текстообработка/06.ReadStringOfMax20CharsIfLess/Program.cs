using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//Print the result string into the console.


namespace _06.ReadStringOfMax20CharsIfLess
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            text.Insert(0, Console.ReadLine());
            if (text.Length<20)
            {
                while (text.Length<20)
                {
                    text.Append("*");
                }
                
            }
            Console.WriteLine(text);
        }
    }
}
