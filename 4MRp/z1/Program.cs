using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        int wordCount = GetWordCount(input);
        Console.WriteLine($"Количество слов в строке: {wordCount}");

        Console.ReadKey();
    }

    static int GetWordCount(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return 0;

        string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' },
                                   StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
