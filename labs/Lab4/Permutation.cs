using System;

public static class Permutation
{
    public static void Run()
    {
        Console.WriteLine("=== Проверка перестановки ===\n");
        Console.Write("Введите два слова через пробел: ");
        
        string input = Console.ReadLine();
        string[] words = input.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        if (words.Length != 2)
        {
            Console.WriteLine("Ошибка: нужно ввести ровно два слова!");
            return;
        }
        
        string word1 = SortString(words[0]);
        string word2 = SortString(words[1]);
        
        if (word1 == word2)
            Console.WriteLine($"\n✓ Можно получить перестановкой букв");
        else
            Console.WriteLine($"\n✗ Нельзя получить перестановкой букв");
    }
    
    private static string SortString(string input)
    {
        char[] chars = input.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}
