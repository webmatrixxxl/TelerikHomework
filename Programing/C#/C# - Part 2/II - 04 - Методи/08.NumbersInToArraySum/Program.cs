using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a method that adds two positive integer numbers represented as arrays of 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.


namespace _08.NumbersInToArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            foreach (var item in Add(a, b).Reverse<BigInteger>())
            {
                Console.Write(item);
            }

            Console.WriteLine();
        }
        static List<BigInteger> Add(string a, string b)
        {
            int digit = 0;
            int digitInMind = 0;
            int LengthMax = a.Length > b.Length ? a.Length : b.Length;
            List<BigInteger> result = new List<BigInteger>();

            for (int i = 1; i <= LengthMax; i++)
            {

                if (a.Length <= i - 1)
                {
                    digit = (int.Parse(b[b.Length - i].ToString())) % 10 + digitInMind;
                }
                else if (b.Length <= i - 1)
                {
                    digit = (int.Parse(a[a.Length - i].ToString())) % 10 + digitInMind;
                }
                else
                {
                    digit = (int.Parse(a[a.Length - i].ToString()) + int.Parse(b[b.Length - i].ToString())) % 10 + digitInMind;
                }

                if (a.Length <= i - 1)
                {
                    digitInMind = int.Parse(b[b.Length - i].ToString()) / 10;
                }
                else if (b.Length <= i - 1)
                {
                    digitInMind = int.Parse(a[a.Length - i].ToString()) / 10;
                }
                else
                {
                    digitInMind = (int.Parse(a[a.Length - i].ToString()) + int.Parse(b[b.Length - i].ToString())) / 10;
                }

                if (digit == 10)
                {
                    digit = 0;
                    digitInMind = 1;
                }

                result.Add(digit);

                if (LengthMax == i && digitInMind > 0)
                {

                    result.Add(digitInMind);
                }
            }
            return result;


        }

    }

}
