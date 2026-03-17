using System;

namespace Lab_Task1_Variant9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных для хранения вещественных чисел
            double a, b, sum;

            // Запрос первого числа
            Console.Write("a=");
            a = double.Parse(Console.ReadLine());

            // Запрос второго числа
            Console.Write("b=");
            b = double.Parse(Console.ReadLine());

            // Вычисление суммы
            sum = a + b;

            // Вывод результата с форматированием (2 знака после запятой)
            // Используем спецификатор F2 для вывода чисел с фиксированной точкой и 2 знаками после запятой
            Console.WriteLine($"{a:F2}+{b:F2}={sum:F2}");

            Console.ReadKey();
        }
    }
}