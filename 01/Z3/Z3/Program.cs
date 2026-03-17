using System;

namespace Lab1_Task3_Variant9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных
            double m, z1, z2;

            Console.WriteLine("Расчет по двум формулам (Вариант 9)");
            Console.Write("Введите значение m (m > 0): ");
            m = double.Parse(Console.ReadLine());

            // Проверка области определения (подкоренное выражение и знаменатель)
            if (m <= 0)
            {
                Console.WriteLine("Ошибка: m должна быть строго положительной.");
            }
            else
            {
                // Вычисление z2 (проще, можно использовать для проверки)
                z2 = -Math.Sqrt(m);

                // Вычисление z1 по первой формуле
                // Числитель: sqrt((3m+2)^2 - 24m)
                double numerator = Math.Sqrt(Math.Pow(3 * m + 2, 2) - 24 * m);

                // Знаменатель: 3*sqrt(m) - 2/sqrt(m)
                double denominator = 3 * Math.Sqrt(m) - 2 / Math.Sqrt(m);

                // Проверка знаменателя на ноль
                if (Math.Abs(denominator) < 1e-10)
                {
                    Console.WriteLine("Ошибка: Знаменатель равен нулю.");
                }
                else
                {
                    z1 = numerator / denominator;

                    // Вывод результатов
                    Console.WriteLine("\nРезультаты вычислений:");
                    Console.WriteLine($"m = {m:F4}");
                    Console.WriteLine($"z1 = {z1:F8}");
                    Console.WriteLine($"z2 = {z2:F8}");

                    // Анализ: сравнение результатов с учетом погрешности вычислений
                    if (Math.Abs(z1 - z2) < 1e-7)
                    {
                        Console.WriteLine("Результаты z1 и z2 совпадают (в пределах погрешности).");
                    }
                    else
                    {
                        Console.WriteLine("Результаты z1 и z2 различаются. Возможно, ошибка в расчетах.");
                    }
                }
            }
             Console.ReadKey();
        }
    }
}