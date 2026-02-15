using System;
using System.Linq;

public static class Friday13th
{
    public static void Run()
    {
        Console.WriteLine("=== Пятница 13-е ===\n");
        Console.Write("Введите начальный год: ");
        int startYear = int.Parse(Console.ReadLine());
        
        Console.Write("Введите конечный год: ");
        int endYear = int.Parse(Console.ReadLine());
        
        int[] counts = new int[7];
        
        for (int year = startYear; year <= endYear; year++)
        {
            for (int month = 1; month <= 12; month++)
            {
                DateTime date = new DateTime(year, month, 13);
                int dayOfWeek = ((int)date.DayOfWeek + 6) % 7;
                counts[dayOfWeek]++;
            }
        }
        
        string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", 
                         "Пятница", "Суббота", "Воскресенье" };
        
        Console.WriteLine("\nРаспределение 13-го числа по дням недели:");
        for (int i = 0; i < 7; i++)
        {
            double percent = (double)counts[i] / counts.Sum() * 100;
            Console.WriteLine($"{days[i]}: {counts[i]} раз ({percent:F1}%)");
        }
    }
}
