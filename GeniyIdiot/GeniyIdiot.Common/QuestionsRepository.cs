using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace GeniyIdiotConsoleApp
{
    public class QuestionsRepository
    {
        public static string FileName { get; set; } = "Question.txt";
        private static List<Question> _questions { get; set; } = new List<Question>();

        public static List<Question> GetDefaultQuestions()
        {
            var baseQuestions = new List<Question>()
            {
                new Question
                {
                    Text = "Сколько будет два плюс два умноженное на два?",
                    Answer = 6
                },
                new Question
                {
                    Text = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?",
                    Answer = 9
                },
                new Question
                {
                    Text = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?",
                    Answer = 25
                },
                new Question
                {
                    Text = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?",
                    Answer = 60
                },
                new Question
                {
                    Text = "Пять свечей горело, две потухли. Сколько свечей осталось?",
                    Answer = 2
                },
            };
            return baseQuestions;
        }

        public static List<Question> GetAll()
        {   
            return _questions;
        }

        public static void Load()
        {
            if (File.Exists(FileName))
            {
                var lines = FileManager.Read(FileName);
                _questions.Clear();

                foreach (var line in lines)
                {
                    var parts = line.Split('#');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int answer))
                    {
                        _questions.Add(new Question { Text = parts[0], Answer = answer });
                    }

                }
            }
        }

        public static void Initialize()
        {
            Load();

            if (_questions.Count == 0)
            {
                _questions = GetDefaultQuestions();
                Save();
            }
        }

        public static void Add(string description, int answer)
        {
            var question = new Question()
            {
                Text = description,
                Answer = answer
            };

            _questions.Add(question);

            Save();
        }

        public static void Save()
        {
            FileManager.Write(FileName, _questions, false);
        }

        public static List<Question> GetMixedQuestions()
        {
            var result = _questions.OrderBy(x => Guid.NewGuid()).ToList();
            return result;
        }

        public static void DeleteByIndex(int index)
        {
            if (index >= 0 && index < _questions.Count)
            {
                _questions.RemoveAt(index);
                Save();
            }
        }
    }
}