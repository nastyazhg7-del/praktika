using System;

class Program
{
    static void Main()
    {
        double A = 5.5, B = 2.3, C = 8.1, D = 1.7;

        Console.WriteLine($"До обменов: A = {A}, B = {B}, C = {C}, D = {D}");

        Swap(ref A, ref B);
        Swap(ref C, ref D);
        Swap(ref B, ref C);

        Console.WriteLine($"После обменов: A = {A}, B = {B}, C = {C}, D = {D}");

        Console.ReadKey();
    }

    static void Swap(ref double X, ref double Y)
    {
        double temp = X;
        X = Y;
        Y = temp;
    }
}
