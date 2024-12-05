using System;
using System.Collections.Generic;

namespace TrpoLab
{
    class Рейс
    {
        // Здесь могут быть свойства и методы класса Рейс
    }

    class Администратор : Рейс
    {
        // Свойства для ФИО
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        // Конструктор по умолчанию
        public Администратор() { }

        // Конструктор с параметрами
        public Администратор(string lastName, string firstName, string middleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

        // Метод для получения полного ФИО
        public string GetFIO()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Пример использования класса Администратор
            Администратор администратор = new Администратор("Иванов", "Иван", "Иванович");
            Console.WriteLine(администратор.GetFIO());
        }
    }
}
