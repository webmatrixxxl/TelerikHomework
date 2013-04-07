using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and prints all different letters in the string
//along with information how many times each letter is found. 


namespace _21.ReadTextAndPrintAllDifferentLetters
{
    class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            input = new string(input.Where(c => !char.IsPunctuation(c)).ToArray());          
            Dictionary<char, int> letters = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (letters.ContainsKey(input[i]))
                {
                    letters[input[i]]++;
                }
                else
                {
                    if (input[i] != ' ')
                    {
                        letters.Add(input[i], 1);
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
