using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GeniyIdiotConsoleApp
{
    public class UsersResultRepository
    {
        public static string FileName { get; } = "UsersResults.txt";
        private static List<User> _users { get; set; } = new List<User>();

        public static void Save()
        {
            FileManager.Write(FileName, _users, true);
        }
        public static void Add(User user)
        { 
            _users.Add(user); 
        }

        public static List<string> GetAllStrings()
        {
            return FileManager.Read(FileName);
        }
    }
}