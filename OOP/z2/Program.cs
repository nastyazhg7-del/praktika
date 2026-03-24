using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 2.9: Проверка числа на палиндром");
        Console.WriteLine("-----------------------------------------");

        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int d1 = number / 1000;
        int d2 = (number / 100) % 10;
        int d3 = (number / 10) % 10;
        int d4 = number % 10;

        bool isPalindrome = (d1 == d4) && (d2 == d3);

        Console.WriteLine($"Число {number} читается одинаково слева направо и справа налево: {isPalindrome}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
