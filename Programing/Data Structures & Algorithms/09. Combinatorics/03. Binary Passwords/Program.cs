using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Binary_Passwords
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordTemplate = "***101***";
            int unknownDigitsNumber = 0;

            for (int i = 0; i < passwordTemplate.Length; i++)
            {
                if (passwordTemplate[i] == '*')
                {
                    unknownDigitsNumber++;
                }
            }

            long answer = 1;

            for (int i = 1; i <= unknownDigitsNumber; i++)
            {
                answer *= 2;
            }

            Console.WriteLine(answer);
        }
    }
}
