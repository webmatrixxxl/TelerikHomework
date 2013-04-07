using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front
//of each of its lines. The result should be written to another text file.


namespace _03.InsertLineNumbersInTextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowNumber = 1;

            using (StreamReader input = new StreamReader("../../Program.cs"))
            {
                using (StreamWriter output = new StreamWriter("../../output.txt"))
                {
                    for (string line; (line = input.ReadLine()) != null; rowNumber++)
                    {
                        output.WriteLine("{0}.{1}", rowNumber, line);
                    }
                }
            }
        }
    }
}
