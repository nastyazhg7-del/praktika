using System;

namespace Lab1_Task1_Variant9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявление переменных
            int minutes, hours, mins;

            // Вывод заголовка и приглашения на ввод
            Console.WriteLine("Пересчет временного интервала.");
            Console.WriteLine("Введите величину временного интервала (в минутах) и нажмите <Enter>");
            Console.Write("--> ");

            // Ввод данных и преобразование в целое число
            minutes = int.Parse(Console.ReadLine());

            // Расчет количества часов (целочисленное деление)
            hours = minutes / 60;
            // Расчет остатка минут (остаток от деления)
            mins = minutes % 60;

            // Вывод результата в требуемом формате
            Console.WriteLine($"{minutes} минут --- это {hours} ч. {mins} мин.");

           
             Console.ReadKey();
        }
    }
}
