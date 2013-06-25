using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.BuildATreeFormDir
{
    public class Folder
    {
        public string Name { get; set; }
        public List<FileInfo> Files { get; set; }
        public List<DirectoryInfo> ChildFolder { get; set; }
        public long Size { get; set; }
    }
}