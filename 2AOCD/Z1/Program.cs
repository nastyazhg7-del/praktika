using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 1.9: Количество отрицательных элементов массива");
        Console.WriteLine("--------------------------------------------------------");

        int[] array = new int[15];
        Random rand = new Random();

        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(-50, 51);
            Console.Write(array[i] + " ");
        }

        int negativeCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
                negativeCount++;
        }

        Console.WriteLine($"\n\nКоличество отрицательных элементов: {negativeCount}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}