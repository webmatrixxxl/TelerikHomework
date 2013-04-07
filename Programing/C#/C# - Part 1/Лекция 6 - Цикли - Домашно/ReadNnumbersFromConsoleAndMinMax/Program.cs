using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNnumbersFromConsoleAndMinMax
{
    class Program
    {
        static void Main(string[] args)
        {

            int buffer = 0; //Create varible thate will hold the value of previous member of the sequence 
            int input; //Create varible to hold the inputs
            int max = 0; //Set max = 0 of the sequence
            int min = 0; //Set min = 0 of the sequence
            Console.Write("Please Enter integer > 0 to set size of sequence: ");
            int n = int.Parse(Console.ReadLine()); // Set the size of the sequence
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Enter № {0} in sequence with value: ", i);
                input = int.Parse(Console.ReadLine()); // Set input form console
                if (max < input) // Check if the max < input and if it is max = input
                {
                    max = input;
                }
                if (i == 1) // if we have sequence with only one number min = max = input 
                {
                    min = input;
                }
                if ((buffer >= input && min > input)) // if previeus member is bigger then min if it is smaller min = input
                {
                    min = input;
                }


                buffer = input;

            }
            Console.WriteLine("Max is {0}", max);
            Console.WriteLine("Min is {0}", min);
        }
    }
}
