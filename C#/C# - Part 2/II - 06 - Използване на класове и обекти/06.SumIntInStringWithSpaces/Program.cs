using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. Example:
//        string = "43 68 9 23 318"  result = 461


namespace _06.SumIntInStringWithSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string nums = "43 68 9 23 318";
            string[] num = nums.Split(' ');
            int result = 0;
            for (int i = 0; i < num.Length; i++)
            {
                result += int.Parse(num[i]);
            }
            Console.WriteLine(result);
        }
    }
}
