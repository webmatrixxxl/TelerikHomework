using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".


namespace _20.ExtractPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Static void Main() ABBA using System lamal, exe.";
            text = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] words = text.Split(' ');
            bool palidrome = true;
            for (int i = 0; i < words.Length; i++)
            {
                for (int c = 0; c < words[i].Length; c++)
                {
                    if (words[i][c] != words[i][words[i].Length - 1  - c])
                    {
                        palidrome = false;
                        break;
                    }
                    
                }
                if (palidrome)
                {
                    Console.WriteLine(words[i]);
                    
                }
                palidrome = true;
            }
        }
    }
}
