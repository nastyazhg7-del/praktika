using System;

class Program
{
    static void Main()
    {
        int[] distances = { 120, 45, 180, 90, 30 };

        for (int i = 0; i < distances.Length; i++)
        {
            int hours, minutes;
            DistanceToHours(distances[i], out hours, out minutes);
            Console.WriteLine($"{distances[i]} км = {hours} ч {minutes} мин");
        }

        Console.ReadKey();
    }

    static void DistanceToHours(int KM, out int H, out int M)
    {
        H = KM / 60;
        M = KM % 60;
    }
}
