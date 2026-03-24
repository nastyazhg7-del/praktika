using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 2.9: Удаление максимального и минимального элементов");
        Console.WriteLine("--------------------------------------------------------------");

        int n = 99;
        int[] array = new int[n];
        Random rand = new Random();

        for (int i = 0; i < array.Length; i++)
            array[i] = rand.Next(-100, 101);

        Console.WriteLine("Исходный массив (первые 20 элементов):");
        for (int i = 0; i < 20; i++)
            Console.Write(array[i] + " ");
        Console.WriteLine("...");

        int max = array[0];
        int min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
        }

        Console.WriteLine($"\nМаксимальный элемент: {max}");
        Console.WriteLine($"Минимальный элемент: {min}");

        List<int> newList = new List<int>();
        foreach (int num in array)
        {
            if (num != max && num != min)
                newList.Add(num);
        }

        Console.WriteLine($"\nНовая последовательность (удалены max и min): {newList.Count} элементов");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
