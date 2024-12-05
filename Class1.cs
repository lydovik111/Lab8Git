using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Class1
{

    // Поле класса Class1
    public string Attribute1 { get; set; }

    // Конструктор по умолчанию
    public Class1() { }

    // Конструктор с параметром
    public Class1(string attribute1)
    {
        Attribute1 = attribute1;
    }

    // Метод для получения значения атрибута
    public string GetAttribute1()
    {
        return Attribute1;
    }

    // Метод для установки значения атрибута
    public void SetAttribute1(string attribute1)
    {
        Attribute1 = attribute1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Пример использования класса Class1
        Class1 obj = new Class1("Пример значения");
        Console.WriteLine("Attribute1: " + obj.GetAttribute1());

        // Изменение значения атрибута
        obj.SetAttribute1("Новое значение");
        Console.WriteLine("Attribute1: " + obj.GetAttribute1());
    }
}
