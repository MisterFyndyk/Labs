using System;
using System.Globalization;

public static class MinutesBetweenDates
{
    public static void Run()
    {
        Console.WriteLine("=== Количество минут между датами ===\n");
        
        Console.Write("Введите первую дату (ДД.ММ.ГГГГ): ");
        DateTime date1 = ReadDate();
        
        Console.Write("Введите вторую дату (ДД.ММ.ГГГГ): ");
        DateTime date2 = ReadDate();
        
        TimeSpan diff = date2 - date1;
        Console.WriteLine($"\nРазница: {Math.Abs(diff.TotalMinutes):F0} минут");
    }
    
    private static DateTime ReadDate()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (DateTime.TryParseExact(input, "dd.MM.yyyy", 
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                return date;
            }
            Console.Write("Некорректный формат. Повторите: ");
        }
    }
}
