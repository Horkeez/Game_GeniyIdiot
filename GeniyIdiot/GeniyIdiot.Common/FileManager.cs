using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GeniyIdiotConsoleApp
{
    public class FileManager
    {
        public static void Write<T>(string fileName, List<T> list, bool appendMode)
        {
            var listStrings = list.Select(s => s.ToString()).ToList();
            using (var writer = new StreamWriter(fileName, appendMode, Encoding.UTF8))
            {
                listStrings.ForEach(writer.WriteLine);
            }
            
            if(appendMode)
            {
                list.Clear();
            }
        }

        public static List<string> Read(string fileName)
        {
            var list = new List<string>();
            if (File.Exists(fileName))
            {
                using (var reader = new StreamReader(fileName, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        list.Add(line);
                    }
                }
            }
            return list;
        }
    }
}
