namespace GeniyIdiotConsoleApp
{
    public class Diagnose
    {
        public int Counter { get; set; }
        public string Description
        {
            get
            {
                switch(Counter)
                {
                    case 0: return "Вы кретин :)";
                    case 1: return "Вы идиот )";
                    case 2: return "Вы Дурак !";
                    case 3: return "Вы нормальный человек :)";
                    case 4: return "Вы талант )";
                    case 5: return "Вы ГЕНИЙ !!!";
                    default: return "Кто же ВЫ ??";
                }
            }
        }
        public override string ToString()
        {
            return $"{Description}";
        }
    }
}
