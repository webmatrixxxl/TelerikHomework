using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).


namespace _03.CheckIfBracketsArePutCorrectly
{
    class Program
    {
        static void Main(string[] args)
        {
            int openBracket = 0;
            int closeBracket = 0;
            int count=0;
            string expr = "(a+b)/5-d)(";
            foreach (var item in expr)
            {
                if (item == '(')
                {
                    openBracket++;
                    count++;
                }
                else if (item == ')' && count != 0)
                {
                    count--;
                    closeBracket++;
                }
                
            }
            if (count == 0 && openBracket == closeBracket)
            {
                Console.WriteLine("right");
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
