using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 5.9: Проверка, являются ли строки ступенчатого массива перестановками");
        Console.WriteLine("----------------------------------------------------------------------------");

        int[][] jaggedArray = new int[4][];
        Random rand = new Random();

        jaggedArray[0] = new int[] { 1, 2, 3, 4 };
        jaggedArray[1] = new int[] { 4, 3, 2, 1 };
        jaggedArray[2] = new int[] { 1, 2, 3, 5 };
        jaggedArray[3] = new int[] { 2, 3, 4, 1 };

        Console.WriteLine("Ступенчатый массив:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write($"Строка {i + 1}: ");
            foreach (int val in jaggedArray[i])
                Console.Write(val + " ");
            Console.WriteLine();
        }

        Console.WriteLine("\nРезультаты проверки:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = i + 1; j < jaggedArray.Length; j++)
            {
                bool isPermutation = ArePermutations(jaggedArray[i], jaggedArray[j]);
                Console.WriteLine($"Строка {i + 1} и строка {j + 1} являются перестановками: {isPermutation}");
            }
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static bool ArePermutations(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length) return false;

        var sorted1 = arr1.OrderBy(x => x).ToArray();
        var sorted2 = arr2.OrderBy(x => x).ToArray();

        for (int i = 0; i < sorted1.Length; i++)
        {
            if (sorted1[i] != sorted2[i]) return false;
        }
        return true;
    }
}