using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that finds the maximal increasing sequence
//in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


namespace _05.MaxIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int countbuff = 0;
            int len = 1;
            string num = null;
            string numbuff = null;
            int[] seq = new int[7] { 0, 2, 5, 8, 5, 3, 4 };
            for (int i = 0; i < seq.Length - 1; i++)
            {
                if ((seq[i] + len != seq[i + len] && countbuff <= count && count >= len && seq[i] - len != seq[i - len]))
                {
                    numbuff = num;
                    countbuff = count;
                    num = null;
                    count = 0;
                }
                if (i >= 1)
                {
                    if (seq[i] - len != seq[i - len] && count >= countbuff)
                    {
                        numbuff = num;
                        countbuff = count;
                        num = null;
                        count = 0;
                    }
                    if (seq[i] + len == seq[i + len] || (seq[i] + len != seq[i + len] && seq[i] - len == seq[i - len]))
                    {
                        count++;
                        num += seq[i];
                    }
                }
                if (i == seq.Length - 2 && seq[i] + len == seq[seq.Length - len])
                {
                    count++;
                    num += seq[i + len];
                }

                else if ((i == 0 && seq[i] + len == seq[i + len]))
                {
                    count++;
                    num += seq[i];
                }
            }
            if (countbuff >= count)
            {
                Console.WriteLine(numbuff);
            }
            else if (count >= countbuff)
            {
                Console.WriteLine(num);
            }
        }
    }
}
