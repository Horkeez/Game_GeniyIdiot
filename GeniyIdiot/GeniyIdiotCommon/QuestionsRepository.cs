using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GeniyIdiotCommon
{
    public class QuestionsRepository
    {
        public static string FileName { get; set; } = "Questions.json";

        public static List<Question> GetDefaultQuestions()
        {
            return new List<Question>()
            {
                new Question { Text = "Сколько будет два плюс два умноженное на два?", Answer = 6 },
                new Question { Text = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", Answer = 9 },
                new Question { Text = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?", Answer = 25 },
                new Question { Text = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", Answer = 60 },
                new Question { Text = "Пять свечей горело, две потухли. Сколько свечей осталось?", Answer = 2 },
            };
        }

        public static List<Question> GetAll()
        {

            var fileData = FileManager.Get(FileName);
            var questions = JsonConvert.DeserializeObject<List<Question>>(fileData);
            if (questions == null || questions.Count == 0)
            {
                Save(GetDefaultQuestions());
            }
            return questions ?? GetDefaultQuestions();
        }

        public static void Add(string text, int answer)
        {
            var questions = GetAll();
            questions.Add(new Question { Text = text, Answer = answer });
            Save(questions);
        }

        public static void Save(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileManager.Append(FileName, jsonData);
        }

        public static List<Question> GetMixedQuestions()
        {
            return GetAll().OrderBy(x => Guid.NewGuid()).ToList();
        }

        public static void DeleteByIndex(int index)
        {
            var questions = GetAll();
            questions.RemoveAt(index);
            Save(questions);
        }
    }
}