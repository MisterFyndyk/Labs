using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public static class PopularMonth
{
    public static void Run()
    {
        Console.WriteLine("=== Самый популярный месяц ===\n");
        
        Random rand = new Random();
        List<DateTime> dates = new List<DateTime>();
        
        Console.WriteLine("Сгенерированные даты:");
        for (int i = 0; i < 20; i++)
        {
            int year = rand.Next(2000, 2024);
            int month = rand.Next(1, 13);
            int day = rand.Next(1, 29);
            DateTime date = new DateTime(year, month, day);
            dates.Add(date);
            Console.WriteLine(date.ToString("dd.MM.yyyy"));
        }
        
        var monthGroups = dates.GroupBy(d => d.Month)
                               .Select(g => new { Month = g.Key, Count = g.Count() })
                               .OrderByDescending(g => g.Count);
        
        var mostPopular = monthGroups.First();
        string monthName = new DateTime(2000, mostPopular.Month, 1).ToString("MMMM", new CultureInfo("ru-RU"));
        
        Console.WriteLine($"\nСамый популярный месяц: {monthName}");
        Console.WriteLine($"Количество дат: {mostPopular.Count}");
    }
}
