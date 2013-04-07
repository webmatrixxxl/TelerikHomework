using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.


namespace _24.ListOfWordsInAlpha
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] textWords = text.Split(' ');
            Array.Sort(textWords);
            foreach (var item in textWords)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
