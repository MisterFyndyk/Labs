using System;

public static class Arrows
{
    public static void Run()
    {
        Console.WriteLine("=== Поиск стрелок ===\n");
        Console.Write("Введите последовательность: ");
        string input = Console.ReadLine();
        
        int count = 0;
        for (int i = 0; i <= input.Length - 5; i++)
        {
            string fragment = input.Substring(i, 5);
            if (fragment == ">>-->" || fragment == "<--<<")
                count++;
        }
        
        Console.WriteLine($"\nНайдено стрелок: {count}");
    }
}
