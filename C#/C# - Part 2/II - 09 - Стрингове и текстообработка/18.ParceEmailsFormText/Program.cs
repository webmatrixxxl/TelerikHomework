using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program for extracting all email addresses from given text.
//All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.


namespace _18.ParceEmailsFormText
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Alaa blaa ei tova mi e Mail-a rix@mail.bg i tozi su6to web@mail.bg";
            int index = 0;
            string Id;
            string Host;
            int indexDot = 0;
            string domein;

            StringBuilder email = new StringBuilder();
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                
                    index = words[i].IndexOf("@");
                    indexDot = words[i].IndexOf(".");
                    if (indexDot <= 0 || index <= 0)
                    {
                        continue;
                    }
                    else
                    {
                        Id = words[i].Substring(0, index);
                        Host = words[i].Substring(index, indexDot - index);
                        domein = words[i].Substring(indexDot, words[i].Length - indexDot);
                        Console.Write("{0}@{1}{2} ", Id, Host, domein);

                    }
            }
            Console.WriteLine();
          
        }
    }
}
