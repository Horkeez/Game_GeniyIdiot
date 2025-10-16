using System;
using System.Collections.Generic;
using System.Linq;
using GeniyIdiotCommon;

namespace GeniyIdiotConsoleApp
{
    class Program
    {
        private static void Main()
        {
            while (PlayOneGame()) { }

            Console.WriteLine("\nИгра окончена");
        }

        private static bool PlayOneGame()
        {
            var questions = QuestionsRepository.GetMixedQuestions();
            var countQuestions = questions.Count;
            var currentNumberQuestion = 1;
            var countCorrectAnswers = 0;

            Console.WriteLine("Напишите свое имя: ");
            var userName = GetСorrectStringValue();
            Console.WriteLine($"\nПриступим к игре! {userName}");

            questions.ForEach(question =>
            {
                Console.WriteLine($"\nВопрос {currentNumberQuestion}: {question.Text}");
                var userAnswer = GetValidUserResponse();

                if (userAnswer == question.Answer)
                {
                    countCorrectAnswers++;
                }

                currentNumberQuestion++;
            });

            var diagnose = new Diagnose(countQuestions, countCorrectAnswers);
            var user = new User(userName, diagnose, countCorrectAnswers);

            UsersResultRepository.Add(user);

            PrintResultUser(user);

            if (GetYesNoResponse("Хотите посмотреть результаты предыдущих игр?"))
            {
                PrintAllResults();
            }

            if (GetYesNoResponse("Хотите добавить новый вопрос в программу?"))
            {
                Console.WriteLine("Напишите вопрос:");
                var description = GetСorrectStringValue();
                Console.WriteLine("Напишите ответ:");
                var answer = GetValidUserResponse();

                QuestionsRepository.Add(description, answer);

                Console.WriteLine("Вопрос добавлен!");
            }
            if (GetYesNoResponse("Хотите удалить вопрос из программы?"))
            {
                var listQuestions = QuestionsRepository.GetAll();
                Console.WriteLine("Список вопросов:");
                PrintLines(listQuestions);
                Console.Write("Введите номер вопроса, который хотите удалить: ");
                int numberQuestion;

                while (true)
                {
                    numberQuestion = GetValidUserResponse();
                    if (numberQuestion > 0 && numberQuestion <= listQuestions.Count)
                    {
                        break;
                    }
                    Console.WriteLine("Введите существующий номер вопроса!");
                }
                QuestionsRepository.DeleteByIndex(numberQuestion - 1);

                Console.WriteLine("Вопрос успешно удалён!!");
            }

            return GetYesNoResponse("Хотите сыграть еще раз?");
        }

        private static void PrintLines<T>(List<T> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {list[i]}");
            }
        }

        private static void PrintResultUser(User user)
        {
            Console.WriteLine("\nКоличество правильных ответов: " + user.CountCorrectAnswers);
            Console.WriteLine($"Ваш диагноз, {user.Name}: {user.Diagnose}");
        }

        private static void PrintAllResults()
        {
            Console.WriteLine("\n_______________________________Результаты предыдущих игр_______________________________\n");
            var results = UsersResultRepository.GetAll();
            PrintLines(results);
        }

        public static int GetValidUserResponse()
        {
            while (true)
            {
                var userInput = Console.ReadLine();

                try
                {
                    return Convert.ToInt32(userInput);
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nВы ввели не числовое значение, попробуйте еще раз");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nВведенное число слишком большое, попробуйте еще раз");
                }
            }
        }

        private static bool GetYesNoResponse(string str)
        {
            Console.WriteLine($"\n{str}");
            Console.WriteLine("Напишите 'ДА' или 'НЕТ':");
            while (true)
            {
                var answerUser = Console.ReadLine().ToLower().Trim();

                switch (answerUser)
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

        public static string GetСorrectStringValue()
        {
            var inputString = Console.ReadLine();
            var flagInputString = string.IsNullOrWhiteSpace(inputString);
            while (true)
            {
                if (!flagInputString)
                {
                    return inputString;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода(поле не может быть пустым!)\nПовторите попытку: ");
                    inputString = Console.ReadLine();
                    flagInputString = string.IsNullOrWhiteSpace(inputString);
                }
            }
        }
    }
}