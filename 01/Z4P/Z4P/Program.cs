using System;

namespace Lab_Task4_Variant9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных
            double v0, a, t, v, s;

            Console.WriteLine("Вычисление скорости и пути при равноускоренном движении");

            // Ввод исходных данных
            Console.Write("Введите начальную скорость v0 (м/с): ");
            v0 = double.Parse(Console.ReadLine());

            Console.Write("Введите ускорение a (м/с²): ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Введите время движения t (с): ");
            t = double.Parse(Console.ReadLine());

            // Вычисление скорости и пути
            v = v0 + a * t;
            s = v0 * t + (a * t * t) / 2; // Можно также использовать Math.Pow(t, 2)

            // Вывод результатов с форматированием
            Console.WriteLine("\nРезультаты вычислений:");
            Console.WriteLine($"Скорость тела в момент времени t = {t:F2} с: {v:F2} м/с");
            Console.WriteLine($"Путь, пройденный телом за время t = {t:F2} с: {s:F2} м");

             Console.ReadKey();
        }
    }
}
