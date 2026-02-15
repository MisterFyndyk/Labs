using System;

public static class Numerologist
{
    public static void Run()
    {
        Console.WriteLine("=== Нумеролог ===\n");
        Console.Write("Введите число секунд: ");
        string number = Console.ReadLine();
        
        int steps = 0;
        string current = number;
        
        while (current.Length > 1)
        {
            int sum = 0;
            foreach (char c in current)
                sum += c - '0';
            
            current = sum.ToString();
            steps++;
        }
        
        Console.WriteLine($"\nРезультат: {current}");
        Console.WriteLine($"Количество операций: {steps}");
    }
}
