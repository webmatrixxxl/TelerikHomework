using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
//operation over the first letter of the string with the first of the key, the second – with the second, 
//etc. When the last key character is reached, the next is the first.


namespace _07.CodeDecodeText
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = "kotva";
            string text = "potnik";

            Console.WriteLine(Encrypt(text,key));
            Console.WriteLine(Decrypt(Encrypt(text, key),key));
        }
        static string Encrypt(string text, string key)
        {
             StringBuilder enc = new StringBuilder();
          
            for (int i = 0, c=0; i < text.Length; i++, c++)
            {
                enc.Append((char)(key[c]^text[i]));
                if (key.Length>=c)
                {
                    c = 0;
                }
            }
            return enc.ToString();
        }
        static string Decrypt(string text, string key)
        {
            return Encrypt(text, key);
        }
    }
}
