namespace GeniyIdiotCommon
{
    public class Diagnose(int countQuestions, int countCorrectAnswers)
    {
        public string Description
        {
            get
            {
                int percentage = GetCorrectAnswersPercentage();
                if (percentage < 20) return "Кретин";
                if (percentage < 40) return "Идиот";
                if (percentage < 60) return "Дурак";
                if (percentage < 75) return "Нормальный";
                if (percentage <= 90) return "Талант";
                return "Гений";
            }
        }

        public int GetCorrectAnswersPercentage()
        {
            var percentage = (double)countCorrectAnswers / countQuestions * 100;
            var resultRounding = (int)Math.Round(percentage);
            return resultRounding;
        }
        public override string ToString()
        {
            return Description;
        }
    }
}