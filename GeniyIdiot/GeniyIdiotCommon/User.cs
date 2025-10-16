using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniyIdiotCommon
{
    public class User
    {
        public string Name { get; set; }
        public Diagnose Diagnose { get; set; }
        public int CountCorrectAnswers { get; set; }

        public User(string name, Diagnose diagnose, int countCorrectAnswers)
        {
            Name = name;
            Diagnose = diagnose;
            CountCorrectAnswers = countCorrectAnswers;
        }
        
        public override string ToString()
        {
            return $"{Name}, диагноз - {Diagnose}, Правильных ответов: {CountCorrectAnswers}";
        }
    }
}