using System;
using System.Linq;

namespace HW_files_combine
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new FileWriter("Directory\\test.txt", "Directory");
            writer.WriteCombined();
        }
    }
}

