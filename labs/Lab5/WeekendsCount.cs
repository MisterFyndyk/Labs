using System;

public static class WeekendsCount
{
    public static void Run()
    {
        Console.WriteLine("=== Количество выходных в году ===\n");
        Console.Write("Введите год: ");
        
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            int weekends = 0;
            for (int month = 1; month <= 12; month++)
            {
                int daysInMonth = DateTime.DaysInMonth(year, month);
                for (int day = 1; day <= daysInMonth; day++)
                {
                    DateTime date = new DateTime(year, month, day);
                    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        weekends++;
                    }
                }
            }
            
            Console.WriteLine($"\nВ {year} году {weekends} выходных дней");
        }
    }
}
