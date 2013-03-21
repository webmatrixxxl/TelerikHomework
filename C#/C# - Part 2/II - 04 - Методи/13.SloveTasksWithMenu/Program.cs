using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//        Create appropriate methods.
//        Provide a simple text-based menu for the user to choose which task to solve.
//        Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0


namespace _13.SloveTasksWithMenu
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Chose what to do:");
            Console.WriteLine("1. Avrage sum of sequence");
            Console.WriteLine("2. Slove Linear sequence a*x+b=0");
            Console.WriteLine("3. Reverse the digits of a number");
            int opt = int.Parse(Console.ReadLine());
            switch (opt)
            {
                case 1:
                    Console.WriteLine(Average());
                    break;
                case 2:
                       Console.WriteLine(Linear());
                    break;
                case 3:
                    Console.WriteLine(ReverseWithString());
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
            int[] num = new int[] { 1, 5, 8, 12 };

        }
        static double Linear()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            while (a==0)
            {
                Console.Write("Plz enter a>0. a=");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            return -b / a;
        }

        static double Average()
        {
            Console.WriteLine("Enter members of sequence each per line.");
            Console.WriteLine("To stop plz write STOP");
            string input = null;
            List<int> seq = new List<int>();
            while (input != "STOP")
            {
                Console.Write("Enter member: ");
                input = Console.ReadLine();
                if (input != "STOP")
                {
                    seq.Add(int.Parse(input));

                }
            }
            return seq.Average();
        }

        static decimal ReverseWithString()
        {
            Console.Write("Enter NUMBER to be reversed: ");
            string num = Console.ReadLine();
            string numRev = null;
            for (int i = num.Length - 1; i >= 0; i--)
            {
                numRev += num[i];
            }

            return decimal.Parse(numRev);
        }
    }
}
