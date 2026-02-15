using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public static class TicketWindows
{
    public static void Run()
    {
        Console.WriteLine("=== Кассы вокзала ===\n");
        Console.WriteLine("Введите расписание в формате: 00:00-01:00,00:30-02:30,...");
        
        string input = Console.ReadLine();
        string[] intervals = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
        
        List<(TimeSpan start, TimeSpan end)> windows = new List<(TimeSpan, TimeSpan)>();
        
        foreach (string interval in intervals)
        {
            string[] times = interval.Split('-');
            if (times.Length == 2)
            {
                if (TimeSpan.TryParseExact(times[0], @"hh\:mm", CultureInfo.InvariantCulture, out TimeSpan start) &&
                    TimeSpan.TryParseExact(times[1], @"hh\:mm", CultureInfo.InvariantCulture, out TimeSpan end))
                {
                    windows.Add((start, end));
                }
            }
        }
        
        int maxCount = 0;
        TimeSpan bestTime = TimeSpan.Zero;
        
        for (int minute = 0; minute < 24 * 60; minute++)
        {
            TimeSpan current = TimeSpan.FromMinutes(minute);
            int count = windows.Count(w => current >= w.start && current < w.end);
            
            if (count > maxCount)
            {
                maxCount = count;
                bestTime = current;
            }
        }
        
        Console.WriteLine($"\nМаксимальное количество касс: {maxCount}");
        Console.WriteLine($"Время: {bestTime:hh\\:mm}");
    }
}
