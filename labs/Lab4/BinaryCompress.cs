using System;
using System.Text;

public static class BinaryCompress
{
    public static void Run()
    {
        Console.WriteLine("=== Сжатие бинарных последовательностей ===\n");
        Console.Write("Введите бинарную последовательность: ");
        string input = Console.ReadLine();
        
        string letters = "abcdefghijklmnopqrstuvwxyz";
        StringBuilder result = new StringBuilder();
        int i = 0;
        
        while (i < input.Length)
        {
            if (input[i] == '1')
            {
                result.Append('a');
                i++;
            }
            else if (input[i] == '0')
            {
                int zeroCount = 1;
                i++;
                
                while (i < input.Length && input[i] == '0')
                {
                    zeroCount++;
                    i++;
                }
                
                if (i < input.Length && input[i] == '1')
                {
                    if (zeroCount < letters.Length)
                        result.Append(letters[zeroCount]);
                    else
                        result.Append('?');
                    i++;
                }
            }
            else
            {
                result.Append('?');
                i++;
            }
        }
        
        Console.WriteLine($"\nРезультат сжатия: {result}");
    }
}
