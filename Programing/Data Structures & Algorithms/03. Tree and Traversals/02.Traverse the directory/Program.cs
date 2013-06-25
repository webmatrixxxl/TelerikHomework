using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.Traverse_the_directory
{

    /// <summary>
    /// Sample class, which traverses recursively given directory
    /// based on the Depth-First-Search (DFS) algorithm
    /// </summary>
    public static class DirectoryTraverserDFS
    {
        private static List<string> files = new List<string>();

        private static void TraverseFiles(DirectoryInfo dir, string fileExtension)
        {
            try
            {
                // Visit the current directory
                //Console.WriteLine(dir.FullName);
                string[] currentDirFiles = Directory.GetFiles(dir.FullName, fileExtension);
                files.AddRange(currentDirFiles);

                DirectoryInfo[] children = dir.GetDirectories();

                // For each child go and visit its subtree
                foreach (DirectoryInfo child in children)
                {
                    TraverseFiles(child, fileExtension);
                }
            }
            catch
            {

            }
        }

        private static void TraverseFiles(string directory, string fileExtension)
        {
            TraverseFiles(new DirectoryInfo(directory), fileExtension);
        }

        public static void Main()
        {
            TraverseFiles("C:\\ ", "*.exe");

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}