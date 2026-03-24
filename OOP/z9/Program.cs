using System;

class Program
{
    static void Main()
    {
        double A = 0;
        double B = Math.PI / 2;
        int M = 20;

        double H = (B - A) / M;
        double x = A;

        Console.WriteLine("x\t\ty");

        for (int i = 1; i <= M; i++)
        {
            double y = Math.Sin(x) - Math.Cos(x);

            Console.WriteLine($"{x:F4}\t{y:F4}");

            x = x + H;
            Console.ReadKey();
        }
    }
}
