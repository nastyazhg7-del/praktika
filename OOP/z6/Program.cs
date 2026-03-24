using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 6.9: Дни до конца месяца");
        Console.WriteLine("---------------------------------");

        Console.Write("Введите номер дня месяца (1-31): ");
        int day = int.Parse(Console.ReadLine());

        Console.Write("Введите номер месяца (1-12): ");
        int month = int.Parse(Console.ReadLine());

        // Определяем количество дней в месяце
        int daysInMonth;
        switch (month)
        {
            case 2: // Февраль
                daysInMonth = 28;
                break;
            case 4: // Апрель
            case 6: // Июнь
            case 9: // Сентябрь
            case 11: // Ноябрь
                daysInMonth = 30;
                break;
            default: // Остальные месяцы
                daysInMonth = 31;
                break;
        }

        if (day >= 1 && day <= daysInMonth)
        {
            int daysLeft = daysInMonth - day;
            Console.WriteLine($"До конца месяца осталось {daysLeft} дней");

            if (daysLeft == 0)
                Console.WriteLine("Это последний день месяца!");
        }
        else
        {
            Console.WriteLine("Ошибка: такого дня нет в указанном месяце");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
