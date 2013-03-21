using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_The_third_digit_is_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter at least 3-digit integer number: ");
            int number = int.Parse(Console.ReadLine());
            int number100 = number / 100;
            int number1000 = number100 % 10;
            bool check = (number1000 == 7);
            Console.WriteLine("\"The third digit from right to left is 7\" is: {0}", check);

        }
    }
}
