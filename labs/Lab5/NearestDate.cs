using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public static class NearestDate
{
    public static void Run()
    {
        Console.WriteLine("=== Ближайшая дата к сегодня ===\n");
        Console.WriteLine("Введите даты через пробел (ДД.ММ.ГГГГ):");
        
        string input = Console.ReadLine();
        string[] dateStrings = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        List<DateTime> dates = new List<DateTime>();
        DateTime today = DateTime.Today;
        
        foreach (string dateStr in dateStrings)
        {
            if (DateTime.TryParseExact(dateStr, "dd.MM.yyyy", 
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                dates.Add(date);
            }
        }
        
        if (dates.Count > 0)
        {
            DateTime nearest = dates.OrderBy(d => Math.Abs((d - today).Days)).First();
            Console.WriteLine($"\nБлижайшая дата: {nearest:dd.MM.yyyy}");
            Console.WriteLine($"Разница: {Math.Abs((nearest - today).Days)} дней");
        }
    }
}
