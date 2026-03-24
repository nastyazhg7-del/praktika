using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("ЗАДАНИЕ 4.9: Сравнение суммы первой и предпоследней строк");
        Console.WriteLine("---------------------------------------------------------");

        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];
        Random rand = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rand.Next(-50, 51);
            }
        }

        Console.WriteLine("\nИсходная матрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + "\t");
            Console.WriteLine();
        }

        int sumFirst = 0;
        for (int j = 0; j < cols; j++)
            sumFirst += matrix[0, j];

        int sumSecondLast = 0;
        for (int j = 0; j < cols; j++)
            sumSecondLast += matrix[rows - 2, j];

        Console.WriteLine($"\nСумма первой строки: {sumFirst}");
        Console.WriteLine($"Сумма предпоследней строки: {sumSecondLast}");

        if (sumFirst > sumSecondLast)
            Console.WriteLine("Сумма элементов в первой строке больше");
        else if (sumFirst < sumSecondLast)
            Console.WriteLine("Сумма элементов в предпоследней строке больше");
        else
            Console.WriteLine("Суммы строк равны");

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
