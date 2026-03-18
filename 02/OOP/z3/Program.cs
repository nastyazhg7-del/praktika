using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 3.9: Сумма 1 + 1/2 + 1/3 + ... + 1/N");
        Console.WriteLine("----------------------------------------------");

        Console.Write("Введите целое число N (1-20): ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 1.0 / i;
            Console.WriteLine($"После добавления 1/{i}: {sum:F4}");
        }

        Console.WriteLine($"\nИтоговая сумма: {sum:F4}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
