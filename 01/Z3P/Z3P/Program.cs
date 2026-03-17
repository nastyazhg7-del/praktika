using System;

namespace Lab_Task3_Variant9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных
            double x = 2.7; // Значение x задано в условии
            double y;
            double numerator, denominator;

            Console.WriteLine($"Вычисление значения функции при x = {x}");

            // Вычисление числителя: ln(x + sqrt(x^2 + 9)) - 2
            double sqrtPart = Math.Sqrt(x * x + 9); // sqrt(x^2 + 9)
            double logArgument = x + sqrtPart;      // x + sqrt(x^2 + 9)
            numerator = Math.Log(logArgument) - 2;  // ln(x + sqrt(x^2 + 9)) - 2

            // Вычисление знаменателя: 7 * arctg(x)
            denominator = 7 * Math.Atan(x);         // 7 * arctg(x)

            // Проверка знаменателя на ноль
            if (Math.Abs(denominator) < 1e-10)
            {
                Console.WriteLine("Ошибка: знаменатель равен нулю (arctg(x) = 0).");
            }
            else
            {
                // Вычисление результата
                y = numerator / denominator;

                // Вывод результата с точностью до 4 знаков после запятой
                Console.WriteLine($"y = {y:F4}");
            }

             Console.ReadKey();
        }
    }
}
