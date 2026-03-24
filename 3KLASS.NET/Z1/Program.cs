using System;

class A
{
    public int a;
    public int b;

    public A(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public double CalculateExpression()
    {
        return (Math.Sin(b) + 4) / (2 * a);
    }

    public int SquareOfSum()
    {
        return (a + b) * (a + b);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите значение b: ");
        int b = int.Parse(Console.ReadLine());

        A obj = new A(a, b);

        Console.WriteLine($"\na = {obj.a}, b = {obj.b}");
        Console.WriteLine($"Значение выражения (sin(b) + 4) / (2a) = {obj.CalculateExpression():F4}");
        Console.WriteLine($"Квадрат суммы a и b = {obj.SquareOfSum()}");

        Console.ReadKey();
    }
}