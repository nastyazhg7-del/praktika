using System;
using System.Text;

public static class StringExtensions
{
    public static string GetFirstLettersOfWords(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            return string.Empty;

        string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' },
                                   StringSplitOptions.RemoveEmptyEntries);

        StringBuilder result = new StringBuilder();

        foreach (string word in words)
        {
            if (word.Length > 0)
                result.Append(word[0]);
        }

        return result.ToString();
    }
}

class Program
{
    static void Main()
    {
        string text = "Hello World from C# Programming";

        string firstLetters = text.GetFirstLettersOfWords();

        Console.WriteLine($"Исходная строка: \"{text}\"");
        Console.WriteLine($"Первая буква каждого слова: \"{firstLetters}\"");

        Console.ReadKey();
    }
}