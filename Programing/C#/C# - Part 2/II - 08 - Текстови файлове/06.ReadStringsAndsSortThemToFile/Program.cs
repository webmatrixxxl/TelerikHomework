using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
//      Ivan			George
//      Peter			Ivan
//      Maria			Maria
//      George  	    Peter


namespace _06.ReadStringsAndsSortThemToFile
{
    class Program
    {
      
        static void Main()
        {
            List<string> lines = ReadLines(); // File.ReadAllLines

            lines.Sort();

            WriteLines(lines); // File.WriteAllLines
        }

        static List<string> ReadLines()
        {
            List<string> lines = new List<string>();

            using (StreamReader input = new StreamReader("../../text1.txt"))
            {
                for (string line; (line = input.ReadLine()) != null; )
                {
                    lines.Add(line);
                }
            }
            return lines;
        }

        static void WriteLines(List<string> lines)
        {
            using (StreamWriter output = new StreamWriter("../../output.txt"))
            {
                foreach (string line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }

    }
}
