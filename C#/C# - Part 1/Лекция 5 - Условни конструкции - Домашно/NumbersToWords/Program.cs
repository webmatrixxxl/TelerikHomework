using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string a0 = "Нула";
            string a1 = "Едно";
            string a2 = "Две";
            string a3 = "Трие";
            string a4 = "Четири";
            string a5 = "Пет";
            string a6 = "Шест";
            string a7 = "Седем";
            string a8 = "Осем";
            string a9 = "Демет";
            string a10 = "десет";
            string[] num = { "Нула", "Едно", "Две", "Три", "Четири", "Пет", "Шест", "Седем", "Осем", "Девет", "Десет", "Еди", "Два" };
            string na = "на";
            string and = "и";
            Console.Write("Въведете число: ");
            int i = int.Parse(Console.ReadLine());
            int b =0;
            if ((i>10&&i<=12) || (i<100 && i>19))
            {
                if (i > 12 && i <=30)
                {
                    Console.Write("{0}", num[i / 10 + 10] + num[10]);
                    if (i/10<10)
                    {
                         Console.Write("{0}", and + num[i%10]);
                    }
                    
                }
                else
                {
                    Console.Write("{0}", num[i] + na + num[10]);
                }
            }
            if (i >12 && i<= 19)
            {
                Console.Write("{0}", num[i-10] + na + num[10]);
            }
          
            switch (i)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("{0}", num[i]);
                    break;

            }
       

        }
    }
}
