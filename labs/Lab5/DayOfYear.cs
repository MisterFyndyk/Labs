using System;

public static class DayOfYear
{
    public static void Run()
    {
        Console.WriteLine("=== День недели по номеру дня ===\n");
        Console.Write("Введите год: ");
        int year = int.Parse(Console.ReadLine());
        
        Console.Write("Введите номер дня (1-365): ");
        int dayNumber = int.Parse(Console.ReadLine());
        
        DateTime date = new DateTime(year, 1, 1).AddDays(dayNumber - 1);
        
        Console.WriteLine($"\nДата: {date:dd.MM.yyyy}");
        Console.WriteLine($"День недели: {date:dddd}");
    }
}
