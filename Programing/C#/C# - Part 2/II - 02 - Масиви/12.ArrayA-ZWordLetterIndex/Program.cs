using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.


namespace _12.ArrayA_ZWordLetterIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];
            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)(i + 65);
                
            }
            string word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                for (int c = 0; c < letters.Length; c++)
                {
                    if (word[i]==letters[c])
                    {
                        Console.Write(c+" ");
                    }
                }
            }
        }
    }
}
