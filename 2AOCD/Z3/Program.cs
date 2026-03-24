using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 3.9: Среднее арифметическое > G и количество четных в k-й строке");
        Console.WriteLine("-------------------------------------------------------------------------");

        Console.Write("Введите размер матрицы N (N<10): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите нижнюю границу диапазона a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите верхнюю границу диапазона b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите значение G: ");
        int G = int.Parse(Console.ReadLine());

        Console.Write("Введите номер строки k (1-" + n + "): ");
        int k = int.Parse(Console.ReadLine()) - 1;

        int[,] matrix = new int[n, n];
        Random rand = new Random();

        Console.WriteLine("\nИсходная матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = rand.Next(a, b + 1);
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int sumGreater = 0;
        int countGreater = 0;
        int evenCount = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] > G)
                {
                    sumGreater += matrix[i, j];
                    countGreater++;
                }
                if (i == k && matrix[i, j] % 2 == 0)
                    evenCount++;
            }
        }

        double avgGreater = (countGreater > 0) ? (double)sumGreater / countGreater : 0;

        Console.WriteLine($"\nСреднее арифметическое элементов > {G}: {avgGreater:F2}");
        Console.WriteLine($"Количество четных элементов в {k + 1}-й строке: {evenCount}");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
