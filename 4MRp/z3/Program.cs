using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 3, 9, 1, 7, -2, 4 };

        Console.WriteLine("Массив: " + string.Join(", ", array));

        int min = FindMin(array, array.Length);
        Console.WriteLine($"Минимальный элемент: {min}");

        Console.ReadKey();
    }

    static int FindMin(int[] arr, int n)
    {
        if (n == 1)
            return arr[0];

        int minOfRest = FindMin(arr, n - 1);

        return arr[n - 1] < minOfRest ? arr[n - 1] : minOfRest;
    }
}
