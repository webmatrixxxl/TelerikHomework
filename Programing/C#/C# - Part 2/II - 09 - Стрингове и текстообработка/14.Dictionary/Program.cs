using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//      .NET – platform for applications from Microsoft
//      CLR – managed execution environment for .NET
//      namespace – hierarchical organization of classes



namespace _14.Dictionary
{
    class Program
    {
        static void Main()
        {
            string[,] dictionary = {
                                        {".NET","platform for applications from Microsoft"},
                                        {"CLR","managed execution environment for .NET"},
                                        {"namespace","hierarchical - organization of classes"},
                                   };

            string word = "namespace";

            for (int i = 0; i < dictionary.GetLength(0); i++)
            {
                if (dictionary[i, 0] == word)
                {
                    Console.WriteLine("{0} - {1}", word, dictionary[i, 1]);
                }
            }
        }
    }
}
