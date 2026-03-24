using System;

class Program
{
    static void Main()
    {
        double result1, result2;

        ConvertCurrency(in 100, out result1);
        Console.WriteLine($"100 USD = {result1} EUR (фиксированный курс 0.85)");

        ConvertCurrency(in 100, 1.2, out result2);
        Console.WriteLine($"100 USD = {result2} EUR (курс 1.2)");

        Console.ReadKey();
    }

    static void ConvertCurrency(in double amount, out double convertedAmount)
    {
        double fixedRate = 0.85;
        convertedAmount = amount * fixedRate;
    }

    static void ConvertCurrency(in double amount, double exchangeRate, out double convertedAmount)
    {
        convertedAmount = amount * exchangeRate;
    }
}