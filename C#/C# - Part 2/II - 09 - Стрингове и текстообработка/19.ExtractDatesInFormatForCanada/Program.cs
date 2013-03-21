using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.


namespace _19.ExtractDatesInFormatForCanada
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Краен срок: 23:59 часа на 31.01.2013.Видео - 22.01.2013.Видео - 23 януари 2013 - Наков. Видео - 23.01.2013 - Наков. Краен срок: 23:59 часа на 03.02.2013.";
            string[] words = text.Split(' ');
            DateTime dateValue;
            for (int i = 0; i < words.Length; i++)
            {
                if (DateTime.TryParse(words[i], out dateValue))
                {
                    Console.WriteLine(dateValue.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
                }
            }
        }
    }
}
