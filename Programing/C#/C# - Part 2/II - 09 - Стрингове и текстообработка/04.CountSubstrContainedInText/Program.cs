using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//        Example: The target substring is "in". The text is as follows:
//We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

namespace _04.CountSubstrContainedInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".ToLower();
            int index = 0;
            int counter = 0;
            while (true)
            {
                index = str.IndexOf("in", index + 1);
                if (index < 0)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
