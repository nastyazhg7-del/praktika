using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 5.9: Существование треугольника");
        Console.WriteLine("----------------------------------------");

        Console.Write("Введите сторону a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите сторону c: ");
        double c = double.Parse(Console.ReadLine());

        bool triangleExists = (a + b > c) && (a + c > b) && (b + c > a);

        Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c} существует: {triangleExists}");

        if (triangleExists)
        {
            // Дополнительно: определяем тип треугольника
            if (Math.Abs(a - b) < 0.0001 && Math.Abs(b - c) < 0.0001)
                Console.WriteLine("Это равносторонний треугольник");
            else if (Math.Abs(a - b) < 0.0001 || Math.Abs(a - c) < 0.0001 || Math.Abs(b - c) < 0.0001)
                Console.WriteLine("Это равнобедренный треугольник");

            double aa = a * a, bb = b * b, cc = c * c;
            if (Math.Abs(aa + bb - cc) < 0.0001 || Math.Abs(aa + cc - bb) < 0.0001 || Math.Abs(bb + cc - aa) < 0.0001)
                Console.WriteLine("Это прямоугольный треугольник");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
