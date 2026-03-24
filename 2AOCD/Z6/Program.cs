using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 6.9: Первое слово, состоящее только из цифр");
        Console.WriteLine("-----------------------------------------------------");

        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '\t' },
                                      StringSplitOptions.RemoveEmptyEntries);

        string result = null;
        foreach (string word in words)
        {
            bool isOnlyDigits = true;
            foreach (char c in word)
            {
                if (!char.IsDigit(c))
                {
                    isOnlyDigits = false;
                    break;
                }
            }
            if (isOnlyDigits)
            {
                result = word;
                break;
            }
        }

        if (result != null)
            Console.WriteLine($"Первое слово, состоящее только из цифр: \"{result}\"");
        else
            Console.WriteLine("Слов, состоящих только из цифр, не найдено");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
