using System;

class Program
{
    static void Main()
    {
        ConvertCurrency(100, out double result1);
        Console.WriteLine($"100 USD = {result1} EUR (фиксированный курс 0.85)");

        ConvertCurrency(100, 1.2, out double result2);
        Console.WriteLine($"100 USD = {result2} EUR (курс 1.2)");

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static void ConvertCurrency(double amount, out double convertedAmount)
    {
        double fixedRate = 0.85;
        convertedAmount = amount * fixedRate;
    }

    static void ConvertCurrency(double amount, double exchangeRate, out double convertedAmount)
    {
        convertedAmount = amount * exchangeRate;
    }
}