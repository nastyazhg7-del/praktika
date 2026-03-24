using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 7.9: Длина самой длинной подстроки без повторяющихся символов");
        Console.WriteLine("----------------------------------------------------------------------");

        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        int maxLength = 0;
        int start = 0;
        Dictionary<char, int> lastIndex = new Dictionary<char, int>();

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            if (lastIndex.ContainsKey(c) && lastIndex[c] >= start)
            {
                start = lastIndex[c] + 1;
            }
            lastIndex[c] = i;
            int currentLength = i - start + 1;
            if (currentLength > maxLength)
                maxLength = currentLength;
        }

        Console.WriteLine($"Длина самой длинной подстроки без повторяющихся символов: {maxLength}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
