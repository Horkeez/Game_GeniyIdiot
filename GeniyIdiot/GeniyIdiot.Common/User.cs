using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotConsoleApp
{
    public class User
    {
        public string Name { get; set; }
        public Diagnose Diagnose { get; set; }

        public User(string name, Diagnose diagnose)
        {
            Name = name;
            Diagnose = diagnose;
        }

        public override string ToString()
        {
            return $"{Name}: кол-во правильных ответов - {Diagnose.CounterCorrectAnswers} | ДИАГНОЗ - {Diagnose}";
        }
    }
}