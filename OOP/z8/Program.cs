using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 8.9: Стоимость конфет от 1 до 10 кг");
        Console.WriteLine("============================================");
        Console.WriteLine("Условие:");
        Console.WriteLine("Дано целое число — цена 1 кг конфет.");
        Console.WriteLine("Вывести стоимость 1, 2, ... , 10 кг конфет.");
        Console.WriteLine("============================================");

        Console.Write("Введите цену 1 кг конфет (целое число от 1 до 100): ");
        int price = int.Parse(Console.ReadLine());

        // Проверка входных данных
        if (price < 1 || price > 100)
        {
            Console.WriteLine("Ошибка: цена должна быть в диапазоне от 1 до 100!");
        }
        else
        {
            Console.WriteLine("\n" + new string('-', 30));
            Console.WriteLine("| {0,8} | {1,10} |", "Кг", "Стоимость");
            Console.WriteLine(new string('-', 30));

            // Основной цикл для вывода стоимости от 1 до 10 кг
            for (int kg = 1; kg <= 10; kg++)
            {
                int totalCost = kg * price;
                Console.WriteLine("| {0,8} | {1,10} |", kg, totalCost);
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"\nЦена 1 кг: {price} руб.");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}