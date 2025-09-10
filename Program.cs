using System;
using System.Linq;
using System.Collections.Generic;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var flagGame = true;
            while (flagGame)
            {
                var userName = GetUserName();
                var diagnose = new Diagnose();
                var questions = RandomGenerator(GetQuestions());
                int countQuestions = questions.Count;
                int currentNumberQuestion = 1;

                questions.ForEach(question =>
                {
                    bool flagCurrentUserAnswer = false;
                    while (!flagCurrentUserAnswer)
                    {
                        Console.WriteLine($"\nВопрос {currentNumberQuestion}: {question}");
                        string userInput = Console.ReadLine();
                        if (int.TryParse(userInput, out int userAnswer))
                        {
                            if (userAnswer == question.Answer)
                            {
                                diagnose.Counter++;
                            }
                            flagCurrentUserAnswer = true;
                        }
                        else
                        {
                            Console.WriteLine("\nВы ввели не числовое значение, попробуйте еще раз");
                        }
                    }
                    currentNumberQuestion++;
                });

                PrintResult(diagnose, userName);
                flagGame = WantToPlayAgain();
            }
            Console.WriteLine("\nИгра окончена");
        }

        static bool WantToPlayAgain()
        {
            Console.Write("\nХотите сыграть еще раз? Напишите 'ДА' или 'НЕТ': ");
            while (true)
            {
                string answerUser = Console.ReadLine().ToLower().Trim();
                switch(answerUser)
                {
                    case "да":
                        return true;
                    case "нет":
                        return false;
                    default:
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите 'ДА' или 'НЕТ'.");
                        break;
                }
            }
        }

        static void PrintResult(Diagnose diagnose, string userName)
        {
            Console.WriteLine("\nКоличество правильных ответов: " + diagnose.Counter);
            Console.WriteLine($"Ваш диагноз, {userName}: {diagnose}");
        }

        static string GetUserName()
        {
            Console.WriteLine("Как Вас зовут ?");
            var userName = Console.ReadLine();
            Console.WriteLine($"\nПриступим к игре! {userName}");
            return userName;
        }

        static List<Question> GetQuestions()
        {
            var questions = new List<Question>
            {
                new Question{
                    Description = "Сколько будет два плюс два умноженное на два?",
                    Answer = 6
                },
                new Question{
                    Description = "Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?",
                    Answer = 9
                },
                new Question{
                    Description = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?",
                    Answer = 25
                },
                new Question{
                    Description = "Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?",
                    Answer = 60
                },
                new Question{
                    Description = "Пять свечей горело, две потухли. Сколько свечей осталось?",
                    Answer = 2
                },
            };

            return questions;
        }

        static List<T> RandomGenerator<T>(List<T> questions)
        {
            var result = questions.OrderBy(x => Guid.NewGuid()).ToList();
            return result;
        }
    }
}