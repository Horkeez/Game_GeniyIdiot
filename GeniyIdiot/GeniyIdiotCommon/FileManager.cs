using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Dynamic;

namespace GeniyIdiotCommon
{
    public class FileManager
    {
        public static void Append(string fileName, string data)
        {
            File.WriteAllText(fileName, data, Encoding.UTF8);
        }

        public static string Get(string fileName)
        {
            if (File.Exists(fileName))
            {
                return File.ReadAllText(fileName, Encoding.UTF8);
            }
            return string.Empty;
        }
    }
}
