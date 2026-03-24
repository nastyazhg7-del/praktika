using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 10.9: Проверка наличия русских букв в строке");
        Console.WriteLine("----------------------------------------------------");

        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        bool hasRussianLetters = Regex.IsMatch(input, @"[а-яА-ЯёЁ]");

        Console.WriteLine($"Строка содержит русские буквы: {hasRussianLetters}");

        if (hasRussianLetters)
        {
            MatchCollection matches = Regex.Matches(input, @"[а-яА-ЯёЁ]");
            Console.WriteLine($"Найдено русских букв: {matches.Count}");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}