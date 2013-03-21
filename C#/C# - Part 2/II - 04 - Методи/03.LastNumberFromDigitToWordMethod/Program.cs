using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512  "two", 1024  "four", 12309  "nine".


namespace _03.LastNumberFromDigitToWordMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LastDigitToWord(Console.ReadLine()));

        }
        static string LastDigitToWord(string number)
        {
            string digit = null;

            switch ((number[number.Length - 1]))
            {
                case '0':
                    digit = "Zero";
                    break;
                case '1':
                    digit = "One";
                    break;
                case '2':
                    digit = "Two";
                    break;
                case '3':
                    digit = "Three";
                    break;
                case '4':
                    digit = "Four";
                    break;
                case '5':
                    digit = "Five";
                    break;
                case '6':
                    digit = "Six";
                    break;
                case '7':
                    digit = "Seven";
                    break;
                case '8':
                    digit = "Eigth";
                    break;
                case '9':
                    digit = "Nine";
                    break;
                default:
                    break;

            }
            return digit;
        }
    }
}
