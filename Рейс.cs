using System;

namespace TrpoLab
{
    public class Рейс
    {
        // Свойства класса Рейс
        public string ФИО { get; set; }
        public string ДатаРейса { get; set; }
        public string Бригада { get; set; }

        // Конструктор по умолчанию
        public Рейс() { }

        // Конструктор с параметрами
        public Рейс(string фио, string датаРейса, string бригада)
        {
            ФИО = фио;
            ДатаРейса = датаРейса;
            Бригада = бригада;
        }

        // Метод для получения информации о рейсе
        public void GetINFO()
        {
            Console.WriteLine($"ФИО: {ФИО}");
            Console.WriteLine($"Дата рейса: {ДатаРейса}");
            Console.WriteLine($"Бригада: {Бригада}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования класса Рейс
            Рейс рейс = new Рейс("Иванов Иван Иванович", "01.01.2024", "Бригада А");
            рейс.GetINFO();
        }
    }
}
