using System;
using System.Globalization;

public static class Tomorrow
{
    public static void Run()
    {
        Console.WriteLine("=== Завтрашняя дата ===\n");
        Console.Write("Введите дату (ДД.ММ.ГГГГ): ");
        
        if (DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", 
            CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            DateTime tomorrow = date.AddDays(1);
            Console.WriteLine($"\nЗавтра: {tomorrow:dd.MM.yyyy}");
        }
    }
}
