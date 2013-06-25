using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BuildATreeFormDir
{
    class Program
    {
        private static List<string> files = new List<string>();

        private static Folder TraverseDir(DirectoryInfo dir, string fileExtension)
        {
            try
            {
                // Visit the current directory
                //Console.WriteLine(dir.FullName);
                Folder folder = new Folder();
                folder.Name = dir.FullName;
                //Console.WriteLine(folder.FullName);
                string[] currentDirFiles = Directory.GetFiles(dir.FullName, fileExtension);

                long currentDirSize = 0;

                foreach (var file in currentDirFiles)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    folder.Files.Add(fileInfo);
                    currentDirSize += fileInfo.Length;
                }

                folder.Size = currentDirSize;
                files.AddRange(currentDirFiles);

                DirectoryInfo[] children = dir.GetDirectories();

                // For each child go and visit its subtree
                foreach (DirectoryInfo child in children)
                {
                    folder.ChildFolder.Add(new DirectoryInfo(child.FullName));
                    TraverseDir(child, fileExtension);
                }

                return folder;
            }
            catch
            {

            }

            throw new ArgumentException("Incorect Input Data !");

        }

        private static Folder TraverseDir(string directory, string fileExtension)
        {
            return TraverseDir(new DirectoryInfo(directory), fileExtension);
        }

        private static long FindFolderSize(string subfolder, Folder currentFolder)
        {
            if (currentFolder.Name == subfolder)
            {
                return currentFolder.Size;
            }
            else
            {
                foreach (var folder in currentFolder.ChildFolder)
                {
                    if (folder.Name == subfolder)
                    {
                        return folder.Size;
                    }

                    FindFolderSize(subfolder, folder);
                }
            }
        }

        static void Main()
        {
            Folder currentFolder = TraverseDir("C:\\Windows ", "*.*");
            
            Console.WriteLine(FindFolderSize("System32", currentFolder));

        }
    }
}