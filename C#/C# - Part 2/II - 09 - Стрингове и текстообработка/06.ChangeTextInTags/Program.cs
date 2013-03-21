using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

//You are given a text. Write a program that changes the text in all regions surrounded
//by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 

namespace _06.ChangeTextInTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            int indexOpen = 0;
            int indexClose = 0;
            int indexOld = 0;
            StringBuilder newText = new StringBuilder();

            while (true)
            {
                indexOpen = str.IndexOf("<upcase>", indexOpen + 1);
                if (indexOpen == -1)
                {
                    break;
                }
                newText.Append(str.Substring(indexOld, indexOpen - indexOld));
                indexClose = str.IndexOf("</upcase>", indexClose + 1);
                newText.Append(str.Substring(indexOpen + 8, indexClose - indexOpen - 8).ToUpper());
                indexOld = indexClose + 9;

            }
            newText.Append(str.Substring(indexOld, str.Length - indexOld));
            Console.WriteLine(newText);
        }
    }
}