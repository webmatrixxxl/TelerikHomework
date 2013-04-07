using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to binary numbers (directly).
//Write a program to convert binary numbers to hexadecimal numbers (directly).



namespace _05.HecadecimaToBinary
{
    class Program
    {
        static void Main()
        {
           

            Console.WriteLine(HexToBin());
            Console.WriteLine(BinToHex());
        }
        static string HexToBin()
        {
            string str = Console.ReadLine();
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                switch (str.Substring(i, 1))
                {
                    case "0": result += "0000"; break;
                    case "1": result += "0001"; break;
                    case "2": result += "0010"; break;
                    case "3": result += "0011"; break;
                    case "4": result += "0100"; break;
                    case "5": result += "0101"; break;
                    case "6": result += "0110"; break;
                    case "7": result += "0111"; break;
                    case "8": result += "1000"; break;
                    case "9": result += "1001"; break;
                    case "a": result += "1010"; break;
                    case "b": result += "1011"; break;
                    case "c": result += "1100"; break;
                    case "d": result += "1101"; break;
                    case "e": result += "1110"; break;
                    case "f": result += "1111"; break;
                    default: result += ""; break;
                }
            }
            return result;
        }
        static string BinToHex()
        {
            string str = Console.ReadLine();
            string result = "";
            for (int i = 0; i < str.Length; i+=4)
            {
                switch (str.Substring(i, 4))
                {
                    case "0000": result += "0"; break;
                    case "0001": result += "1"; break;
                    case "0010": result += "2"; break;
                    case "0011": result += "3"; break;
                    case "0100": result += "4"; break;
                    case "0101": result += "5"; break;
                    case "0110": result += "6"; break;
                    case "0111": result += "7"; break;
                    case "1000": result += "8"; break;
                    case "1001": result += "9"; break;
                    case "1010": result += "a"; break;
                    case "1011": result += "b"; break;
                    case "1100": result += "c"; break;
                    case "1101": result += "d"; break;
                    case "1110": result += "e"; break;
                    case "1111": result += "f"; break;
                    default: result += ""; break;
                }
            }
            return result;
        }
    }
}
