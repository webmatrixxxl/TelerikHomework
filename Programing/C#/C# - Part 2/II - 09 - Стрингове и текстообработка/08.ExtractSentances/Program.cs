using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from a given text all sentences containing given word.
//        Example: The word is "in". The text is:


namespace _08.ExtractSentances
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = " in ";
            int index;

            string[] newText = text.Split('.');
            foreach (var item in newText)
            {   
                index = item.IndexOf(word);
                if (index>0)
                {
                    Console.WriteLine(item);
                }

            }
           
        }
        
    }
}
