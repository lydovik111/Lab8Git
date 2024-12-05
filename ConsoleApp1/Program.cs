using System;
using System.Collections.Generic;
using System.Text;

class Flight
{
    public string Make { get; set; }
    public string By { get; set; }
    public DateTime RentalStart { get; set; }

    public Flight(string make, string by, DateTime rentalStart)
    {
        Make = make;
        By = by;
        RentalStart = rentalStart;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8; // Установить кодировку UTF-8

        // Список доступных рейсов (пример)
        List<Flight> availableFlights = new List<Flight>
        {
            new Flight("BEL01", "Иванов И.И.", DateTime.Now.AddDays(1)),
            new Flight("BEL02", " П.П.", DateTime.Now.AddDays(2)),
            new Flight("BEL03", null, DateTime.MinValue) // Доступен
        };

        Console.WriteLine("Введите номер рейса:");
        string requestedMake = Console.ReadLine();

        bool found = false;

        foreach (var Flight in availableFlights)
        {
            if (Flight.Make.Equals(requestedMake, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                if (Flight.By != null)
                {
                    Console.WriteLine($"Рейс {requestedMake} сформирован.\n" +
                                      $"Диспетчер, который сформировал бригаду: {Flight.By}\n" +
                                      $"Дата и время вылета: {Flight.RentalStart}");
                }
                else
                {
                    Console.WriteLine($"Бригада на рейс {requestedMake} формируется.");
                }
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Рейса {requestedMake} не сущетсвует.");
        }
    }
}
