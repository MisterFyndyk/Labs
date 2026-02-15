using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public static class BirthdayMonths
{
    public static void Run()
    {
        Console.WriteLine("=== Статистика по месяцам дней рождений ===\n");
        Console.WriteLine("Введите дни рождения через пробел (ДД.ММ.ГГГГ):");
        
        string input = Console.ReadLine();
        string[] dateStrings = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        
        Dictionary<int, int> monthCount = new Dictionary<int, int>();
        
        foreach (string dateStr in dateStrings)
        {
            if (DateTime.TryParseExact(dateStr, "dd.MM.yyyy", 
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                int month = date.Month;
                if (monthCount.ContainsKey(month))
                    monthCount[month]++;
                else
                    monthCount[month] = 1;
            }
        }
        
        Console.WriteLine("\nМесяцы:");
        var sorted = monthCount.OrderBy(x => x.Key);
        foreach (var item in sorted)
        {
            string monthName = new DateTime(2000, item.Key, 1).ToString("MMMM", new CultureInfo("ru-RU"));
            Console.WriteLine($"{monthName}: {item.Value} дней рождений");
        }
    }
}
