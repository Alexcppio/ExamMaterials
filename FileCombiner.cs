using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW_files_combine
{
    public class FileCombiner
    {
        public string DirPath {get;}
        public FileCombiner(string dirPath) => DirPath = dirPath;
        public List<Person> CombineFiles()
        {
            var lines = new DirectoryReader(DirPath).GetFilesNames();
            List<Person> newList = new FileReader(lines[0]).GetPersons();
            for (var i = 1; i < lines.Length; i++)
                newList = newList.Union(new FileReader(lines[i]).GetPersons(), new PersonComparer()).ToList();
            return newList;
        }
    }
}
