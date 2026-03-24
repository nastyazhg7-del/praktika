using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Подходящие двузначные числа:");

        for (int n = 10; n <= 99; n++)
        {
            int a = n / 10;   // десятки
            int b = n % 10;   // единицы

            if (n == 3 * a * b)
            {
                Console.WriteLine(n);
                Console.ReadKey();
            }
        }
    }
}