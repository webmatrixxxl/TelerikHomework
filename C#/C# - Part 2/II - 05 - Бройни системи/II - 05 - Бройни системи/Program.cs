using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert decimal numbers to their binary representation.


namespace II___05___Бройни_системи
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            List<int> Binary = new List<int>();
            while (num > 0)
            {
                Binary.Add(num % 2);
                num = num / 2;
            }
            Binary.Reverse();
            for (int i = 0; i < Binary.Count; i++)
            {
                Console.Write("{0} ", Binary[i]);
            }
            Console.WriteLine();
        }

    }
}
