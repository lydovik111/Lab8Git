using System;
using System.Collections.Generic;

namespace TrpoLab
{
    class Рейс
    {
        // Здесь могут быть свойства и методы класса Рейс
    }

    class Диспетчер : Рейс
    {
        // Свойства для ФИО
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        // Конструктор по умолчанию
        public Диспетчер() { }

        // Конструктор с параметрами
        public Диспетчер(string lastName, string firstName, string middleName)
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
            // Пример использования класса Диспетчер
            Диспетчер диспетчер = new Диспетчер("Петров", "Петр", "Петрович");
            Console.WriteLine(диспетчер.GetFIO());
        }
    }
}
