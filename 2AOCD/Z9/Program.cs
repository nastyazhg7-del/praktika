using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 9.9: Преобразование StringBuilder в string и обратно");
        Console.WriteLine("-------------------------------------------------------------");

        StringBuilder sb = new StringBuilder();

        Console.Write("Введите строку для StringBuilder: ");
        string userInput = Console.ReadLine();

        sb.Append(userInput);

        Console.WriteLine($"\nСодержимое StringBuilder: {sb}");
        Console.WriteLine($"Тип: {sb.GetType().Name}");

        string convertedString = sb.ToString();
        Console.WriteLine($"\nПреобразовано в string: {convertedString}");
        Console.WriteLine($"Тип: {convertedString.GetType().Name}");

        StringBuilder newSb = new StringBuilder(convertedString);
        Console.WriteLine($"\nПреобразовано обратно в StringBuilder: {newSb}");
        Console.WriteLine($"Тип: {newSb.GetType().Name}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
