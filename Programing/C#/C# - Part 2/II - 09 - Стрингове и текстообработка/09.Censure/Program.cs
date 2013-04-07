using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks

namespace _09.Censure
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = "PHP, CLR, Microsoft";
            string[] forbidenWords = words.Split(',');
            
            for (int i = 0; i < forbidenWords.Length; i++)
            {
                text = text.Replace(forbidenWords[i].Trim(), new string('*', forbidenWords[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
