using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HW_files_combine
{
    public class DirectoryReader
    {
        public string Path { get; }
        public DirectoryReader(string path) => Path = path;
        public string[] GetFilesNames() => Directory.GetFiles(Path);
    }
}
