using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given an array of strings. Write a method that sorts the array by the
//length of its elements (the number of characters composing them).


namespace _05.SortStringArrayByStringsLenght
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[5]
            {
                "golqmoooo","golqqqmooototototo","bba","bababa","bababa"
            };
         
            foreach (var item in QuickSort(str, 0, str.Length - 1))
            {
                Console.WriteLine(item);
            }
        }

        private static string[] QuickSort(string[] str, int left, int right)
        {
            int i = left;
            int j = right;
            double pivotValue = ((left + right) / 2);
            int x = str[Convert.ToInt32(pivotValue)].Length;
            string temp;
            while (i <= j)
            {
                while (str[i].Length < x)
                {
                    i++;
                }
                while (x < str[j].Length)
                {
                    j--;
                }
                if (i <= j)
                {
                    temp = str[i];
                    str[i++] = str[j];
                    str[j--] = temp;
                }
            }
            if (left < j)
            {
                QuickSort(str, left, j);
            }
            if (i < right)
            {
                QuickSort(str, i, right);
            }
            return str;
        }
    }
}
