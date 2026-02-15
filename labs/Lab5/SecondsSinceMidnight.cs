using System;
using System.Globalization;

public static class SecondsSinceMidnight
{
    public static void Run()
    {
        Console.WriteLine("=== Секунды с начала суток ===\n");
        Console.Write("Введите время (hh:mm:ss): ");
        
        if (TimeSpan.TryParseExact(Console.ReadLine(), @"hh\:mm\:ss", 
            CultureInfo.InvariantCulture, out TimeSpan time))
        {
            long seconds = (long)time.TotalSeconds;
            Console.WriteLine($"\nСекунд с начала суток: {seconds}");
        }
    }
}
