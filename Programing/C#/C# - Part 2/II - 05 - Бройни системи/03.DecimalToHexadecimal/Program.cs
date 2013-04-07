using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their hexadecimal representation.


namespace _03.DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = int.Parse(Console.ReadLine());
            StringBuilder hexNum = new StringBuilder();
            while (Num > 0)
            {
                switch (Num % 16)
                {
                    case 10:
                        hexNum.Append('A');
                        break;
                    case 11:
                        hexNum.Append('B');
                        break;
                    case 12:
                        hexNum.Append('C');
                        break;
                    case 13:
                        hexNum.Append('D');
                        break;
                    case 14:
                        hexNum.Append('E');
                        break;
                    case 15:
                        hexNum.Append('F');
                        break;
                    default:
                        hexNum.Append(Num % 16);
                        break;
                }
                Num = Num / 16;
            }
            string endNum = hexNum.ToString();
            for (int i = endNum.Length - 1; i > -1; i--)
            {
                Console.Write(endNum[i]);
            }
            Console.WriteLine();
          
        }
    }
}
