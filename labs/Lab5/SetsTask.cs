using System;
using System.Collections.Generic;
using System.Linq;

public static class SetsTask
{
    public static void Run()
    {
        Console.WriteLine("=== Задача из учебника (множества) ===\n");
        Console.WriteLine("Введите номер задачи (1-20): ");
        
        if (int.TryParse(Console.ReadLine(), out int taskNumber))
        {
            Console.WriteLine($"\nРешение задачи №{taskNumber}:");
            
            var setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            var setB = new HashSet<int> { 4, 5, 6, 7, 8 };
            
            Console.WriteLine("Множество A: " + string.Join(", ", setA));
            Console.WriteLine("Множество B: " + string.Join(", ", setB));
            Console.WriteLine("Объединение: " + string.Join(", ", setA.Union(setB)));
            Console.WriteLine("Пересечение: " + string.Join(", ", setA.Intersect(setB)));
            Console.WriteLine("Разность A-B: " + string.Join(", ", setA.Except(setB)));
        }
    }
}
