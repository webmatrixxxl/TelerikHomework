using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and replaces all series of 
//consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".


namespace _23.ReadStringReplaceIndentical
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder str = new StringBuilder(text);

            for (int letter = 0; letter < str.Length - 1; letter++)
            {
                if (str[letter] == str[letter + 1])
                {
                    str.Remove(letter, 1);
                    letter--;
                }
            }
            Console.WriteLine(str);
        }
    }
}
