using System;
using System.Globalization;

public static class BirthdayCountdown
{
    public static void Run()
    {
        Console.WriteLine("=== Дни до дня рождения ===\n");
        Console.Write("Введите день рождения (ДД.ММ): ");
        string input = Console.ReadLine();
        
        if (DateTime.TryParseExact(input, "dd.MM", 
            CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthday))
        {
            DateTime today = DateTime.Today;
            DateTime nextBirthday = new DateTime(today.Year, birthday.Month, birthday.Day);
            
            if (nextBirthday < today)
                nextBirthday = nextBirthday.AddYears(1);
            
            TimeSpan diff = nextBirthday - today;
            
            if (diff.Days == 0)
                Console.WriteLine("🎉 С днём рождения! 🎉");
            else
                Console.WriteLine($"Осталось {diff.Days} дней");
        }
    }
}
