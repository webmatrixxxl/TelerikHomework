using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace III___01___Дефинране_на_класове
{
    static class PathStorage
    {
        public static void Save()
        {
            
            StreamReader reader =
 new StreamReader("somefile.txt");
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0}: {1}",
                        lineNumber, line);
                    line = reader.ReadLine();
                }
            }

        }

    }
}
