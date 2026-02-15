using System;
using System.Globalization;

public static class ExamCountdown
{
    public static void Run()
    {
        Console.WriteLine("=== Счётчик до экзамена ===\n");
        Console.Write("Введите дату экзамена (ДД.ММ.ГГГГ): ");
        DateTime examDate = ReadDate();
        
        while (true)
        {
            Console.Write("\nВведите другую дату (ENTER для выхода): ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            
            if (DateTime.TryParseExact(input, "dd.MM.yyyy", 
                CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime currentDate))
            {
                TimeSpan diff = examDate - currentDate;
                
                if (diff.Days > 0)
                    Console.WriteLine($"Осталось {diff.Days} дней");
                else if (diff.Days < 0)
                    Console.WriteLine($"Прошло {Math.Abs(diff.Days)} дней");
                else
                    Console.WriteLine("Сегодня экзамен!");
            }
        }
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
