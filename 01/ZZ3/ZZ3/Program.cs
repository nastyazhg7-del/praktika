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
            double firstTerm, secondTerm;

            Console.WriteLine($"Вычисление значения функции при x = {x}");

            // Вычисление первого слагаемого: ln(x + sqrt(x^2 + 9))
            double sqrtPart = Math.Sqrt(x * x + 9);     // sqrt(x^2 + 9)
            double logArgument = x + sqrtPart;          // x + sqrt(x^2 + 9)
            firstTerm = Math.Log(logArgument);          // ln(x + sqrt(x^2 + 9))

            // Вычисление второго слагаемого: (x + 1) / arctg(x^2)
            double numerator = x + 1;                    // x + 1
            double arctgArgument = x * x;                // x^2
            double arctgValue = Math.Atan(arctgArgument); // arctg(x^2)

            // Проверка знаменателя на ноль
            if (Math.Abs(arctgValue) < 1e-10)
            {
                Console.WriteLine("Ошибка: знаменатель arctg(x^2) равен нулю.");
            }
            else
            {
                secondTerm = numerator / arctgValue;     // (x+1) / arctg(x^2)

                // Вычисление итогового значения
                y = firstTerm - secondTerm;

                // Вывод результата с точностью до 4 знаков после запятой
                Console.WriteLine($"y = {y:F4}");
            }

             Console.ReadKey();
        }
    }
}
