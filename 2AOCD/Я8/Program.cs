using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 8.9: Преобразование строки в snake_case");
        Console.WriteLine("-----------------------------------------------");

        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        string result = ToSnakeCase(input);
        Console.WriteLine($"Результат: {result}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static string ToSnakeCase(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;

        StringBuilder sb = new StringBuilder();
        sb.Append(char.ToLower(input[0]));

        for (int i = 1; i < input.Length; i++)
        {
            if (char.IsUpper(input[i]))
            {
                sb.Append('_');
                sb.Append(char.ToLower(input[i]));
            }
            else
            {
                sb.Append(input[i]);
            }
        }

        return sb.ToString();
    }
}
