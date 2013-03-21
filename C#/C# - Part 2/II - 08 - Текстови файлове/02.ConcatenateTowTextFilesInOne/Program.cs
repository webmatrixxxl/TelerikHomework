using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that concatenates two text files into another text file.

namespace _02.ConcatenateTowTextFilesInOne
{
    class Program
    {
        static void Main()
        {
            StreamReader FirstFile = new StreamReader("firstFile.txt");
            StreamReader SecondFile = new StreamReader("secondFile.txt");
            using (FirstFile)    // read and write first file
            {
                StreamWriter writer = new StreamWriter("concatenation.txt", false);
                using (writer)
                {
                    string s;
                    while ((s = FirstFile.ReadLine()) != null)
                    {
                        writer.WriteLine(s);
                    }

                }

            }
            using (SecondFile)   //read and append(true) second file to first file
            {
                StreamWriter writer = new StreamWriter("concatenation.txt", true);
                using (writer)
                {
                    string s;
                    while ((s = SecondFile.ReadLine()) != null)
                    {
                        writer.WriteLine(s);
                    }

                }

            }

        }
    }
}
