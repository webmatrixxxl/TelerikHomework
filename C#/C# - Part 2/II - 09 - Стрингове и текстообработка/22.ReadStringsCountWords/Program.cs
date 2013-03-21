using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and lists all different words
//in the string along with information how many times each word is found.

namespace _21.ReadTextAndPrintAllDifferentLetters
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            input = new string(input.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] inputWords = input.Split(' ');
            Dictionary<string, int> letters = new Dictionary<string, int>();

            for (int i = 0; i < inputWords.Length; i++)
            {
                if (letters.ContainsKey(inputWords[i]))
                {
                    letters[inputWords[i]]++;
                }
                else
                {
                    if (input[i] != ' ')
                    {
                        letters.Add(inputWords[i], 1);
                    }
                }
            }
            letters.OrderBy(x => x.Key);
            foreach (var item in letters)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }
        }
    }
}
