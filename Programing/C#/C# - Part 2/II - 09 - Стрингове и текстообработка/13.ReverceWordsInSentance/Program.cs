using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reverses the words in given sentence.
//    Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".


namespace _13.ReverceWordsInSentance
{
    class Program
    {
       static void Main()
    {
        string str = "C# is not C++, not PHP and not Delphi!";
        string[] Words = str.Split(new char[] {'!','.',',',' ', },StringSplitOptions.RemoveEmptyEntries);
        string[] punctoation = str.Split(new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                                                'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                '+', '#', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
                                                'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
                                                'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', ')', '(',
                                                '*', '/', '=', '~', '`' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(Words);
        StringBuilder strWordsReversed = new StringBuilder();
 
        for (int i = 0; i < punctoation.Length; i++)
        {
            strWordsReversed.Append(Words[i]);
            strWordsReversed.Append(punctoation[i]);
        }
        Console.WriteLine(strWordsReversed.ToString());
    }
    }
}
