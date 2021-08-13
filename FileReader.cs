using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HW_files_combine
{
    public class FileReader
    {
        public string Path { get; }
        public FileReader(string path) => Path = path;
        private string GetData()
        {
            using (var reader = File.OpenText(Path))
            {
                if (reader != null)
                    return reader.ReadToEnd();
                throw new NullReferenceException(nameof(reader));
            }
        }
        private string[] GetLines() => GetData().Split('\n');
        public List<Person> GetPersons()
        {
            string[] stringSplit;
            List<Person> list = new List<Person>();
            if (GetLines() != null)
            {
                foreach (var line in GetLines())
                {
                    if (line.ToString().Contains(' '))
                    {
                        stringSplit = line.Split(' ');
                        if(DateTime.TryParse(stringSplit[2], out DateTime date))
                            list.Add(new Person($"{stringSplit[0]} {stringSplit[1]}", date));
                        else if(!DateTime.TryParse(stringSplit[2], out DateTime cannotConvertDate))
                            throw new InvalidCastException(nameof(cannotConvertDate));
                    }
                }
                return list;
            }
            throw new NullReferenceException("GetLines()");
        }
    }
}
