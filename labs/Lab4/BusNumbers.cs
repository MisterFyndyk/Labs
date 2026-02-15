using System;

public static class BusNumbers
{
    public static void Run()
    {
        string validLetters = "ABCEHKMOPTXY";
        Console.WriteLine("=== Номера автобусов ===\n");
        
        while (true)
        {
            Console.Write("Введите номер (ENTER для выхода): ");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            
            bool isValid = input.Length == 6 &&
                          validLetters.Contains(input[0]) &&
                          char.IsDigit(input[1]) &&
                          char.IsDigit(input[2]) &&
                          char.IsDigit(input[3]) &&
                          validLetters.Contains(input[4]) &&
                          validLetters.Contains(input[5]);
            
            Console.WriteLine(isValid ? "✓ Корректный номер" : "✗ Некорректный номер");
        }
    }
}
