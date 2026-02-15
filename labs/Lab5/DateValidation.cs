using System;
using System.Globalization;

public static class DateValidation
{
    public static void Run()
    {
        Console.WriteLine("=== Проверка валидности даты ===\n");
        Console.Write("Введите дату в формате ДД.ММ.ГГГГ: ");
        
        string input = Console.ReadLine();
        
        if (DateTime.TryParseExact(input, "dd.MM.yyyy", 
            CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            Console.WriteLine($"✓ Дата корректна: {date:dd.MM.yyyy}");
        }
        else
        {
            Console.WriteLine("✗ Некорректная дата!");
        }
    }
}
