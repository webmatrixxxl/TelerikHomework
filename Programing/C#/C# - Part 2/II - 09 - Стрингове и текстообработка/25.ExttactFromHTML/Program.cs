using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. Example:


namespace _25.ExttactFromHTML
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            String str = client.DownloadString("http://www.bonis-komers.com");
            foreach (Match text in Regex.Matches(str, "(?<=>).*?(?=<)"))
            {
                if (!String.IsNullOrWhiteSpace(text.Value))
                {
                    Console.WriteLine(text);
                }
            }
        }
    }
}
