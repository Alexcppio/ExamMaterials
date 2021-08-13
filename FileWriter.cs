using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HW_files_combine
{
    public class FileWriter
    {
        public string Path { get; }
        public string DirectoryPath { get; }
        public FileWriter(string path, string directoryPath)
        {
            Path = path;
            DirectoryPath = directoryPath;
        }
        public void WriteCombined()
        {
            var list = new FileCombiner(DirectoryPath).CombineFiles();

            using (var sw = File.CreateText(Path))
            {
                foreach (var line in list)
                    sw.WriteLine(line.ToString());
            }
        }
    }
}
