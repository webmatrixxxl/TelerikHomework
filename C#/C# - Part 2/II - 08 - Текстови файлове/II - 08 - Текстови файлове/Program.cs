using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.


namespace II___08___Текстови_файлове
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;

            using (StreamReader file = new StreamReader("../../Program.cs"))
            {
                for (string row; (row = file.ReadLine()) != null; n++)
                {
                    if (n % 2 == 1)
                    {
                        Console.WriteLine(row);
                    }
                }
            }
        }
    }
}
