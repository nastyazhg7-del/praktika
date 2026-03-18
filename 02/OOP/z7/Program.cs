using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 7.9: Перевод долларов в рубли");
        Console.WriteLine("--------------------------------------");

        Console.Write("Введите текущий курс доллара (рублей за 1 USD): ");
        double exchangeRate = double.Parse(Console.ReadLine());

        Console.WriteLine("\nТаблица перевода долларов в рубли:");
        Console.WriteLine("----------------------");
        Console.WriteLine("| Доллары |  Рубли   |");
        Console.WriteLine("----------------------");

        for (int dollars = 5; dollars <= 500; dollars += 5)
        {
            double rubles = dollars * exchangeRate;
            Console.WriteLine($"| {dollars,7} | {rubles,8:F2} |");
        }

        Console.WriteLine("----------------------");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
