using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GeniyIdiotCommon
{
    public class UsersResultRepository
    {
        public static string FileName { get; } = "UsersResults.json";

        public static void Add(User user)
        {
            var usersResults = GetAll();
            usersResults.Add(user);
            Save(usersResults);
        }

        public static List<User> GetAll()
        {
            var fileData = FileManager.Get(FileName);
            var usersResults = JsonConvert.DeserializeObject<List<User>>(fileData);
            return usersResults ?? new List<User>();
        }

        public static void Save(List<User> usersResults)
        {
            var jsonData = JsonConvert.SerializeObject(usersResults, Formatting.Indented);
            FileManager.Append(FileName, jsonData);
        }
    }
}