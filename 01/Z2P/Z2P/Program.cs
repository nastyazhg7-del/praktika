using System;

namespace Lab_Task2_Variant9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных
            int number, d1, d2, d3;

            Console.Write("Введите трехзначное число (цифры различны): ");
            number = int.Parse(Console.ReadLine());

            // Проверка, что число трехзначное
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: Число не является трехзначным.");
            }
            else
            {
                // Извлечение цифр числа
                d1 = number / 100;          // Первая цифра (сотни)
                d2 = (number / 10) % 10;    // Вторая цифра (десятки)
                d3 = number % 10;            // Третья цифра (единицы)

                // Проверка, что цифры различны
                if (d1 == d2 || d1 == d3 || d2 == d3)
                {
                    Console.WriteLine("Ошибка: Цифры числа должны быть различны.");
                }
                else
                {
                    // Вывод всех возможных перестановок
                    Console.WriteLine("\nЧисла, полученные перестановкой цифр:");
                    Console.WriteLine($"{d1}{d2}{d3}");
                    Console.WriteLine($"{d1}{d3}{d2}");
                    Console.WriteLine($"{d2}{d1}{d3}");
                    Console.WriteLine($"{d2}{d3}{d1}");
                    Console.WriteLine($"{d3}{d1}{d2}");
                    Console.WriteLine($"{d3}{d2}{d1}");
                }
            }
             Console.ReadKey();
        }
    }
}
