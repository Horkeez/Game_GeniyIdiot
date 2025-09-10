namespace GeniyIdiotConsoleApp
{
    public class Question
    {
        public string Description { get; set; }
        public int Answer { get; set; }
        public override string ToString()
        {
            return $"{Description}";
        }
    }
}
