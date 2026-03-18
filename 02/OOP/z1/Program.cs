using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 1.9: Длина окружности и площадь круга");
        Console.WriteLine("---------------------------------------------");

        Console.Write("Введите радиус окружности: ");
        double radius = double.Parse(Console.ReadLine());

        double circumference = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine($"Длина окружности: {circumference:F4}");
        Console.WriteLine($"Площадь круга: {area:F4}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
