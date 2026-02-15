using System;

public static class ProgrammersDay
{
    public static void Run()
    {
        Console.WriteLine("=== День программиста ===\n");
        Console.Write("Введите год: ");
        
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            DateTime programmersDay = new DateTime(year, 1, 1).AddDays(255);
            Console.WriteLine($"\nДень программиста: {programmersDay:dd.MM.yyyy}");
            Console.WriteLine($"День недели: {programmersDay:dddd}");
        }
    }
}
