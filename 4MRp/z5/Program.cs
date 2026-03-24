using System;

abstract class Food
{
    public abstract void Cook();

    public virtual void Serve()
    {
        Console.WriteLine("Подача блюда на стол");
    }
}

class Pizza : Food
{
    public override void Cook()
    {
        Console.WriteLine("Пицца готовится в духовке 15 минут");
    }

    public override void Serve()
    {
        Console.WriteLine("Пицца подается на деревянной доске");
    }
}

class Pasta : Food
{
    public override void Cook()
    {
        Console.WriteLine("Паста варится в кипящей воде 10 минут");
    }

    public override void Serve()
    {
        Console.WriteLine("Паста подается в глубокой тарелке с соусом");
    }
}

class Program
{
    static void Main()
    {
        Food pizza = new Pizza();
        Food pasta = new Pasta();

        Console.WriteLine("=== Пицца ===");
        pizza.Cook();
        pizza.Serve();

        Console.WriteLine("\n=== Паста ===");
        pasta.Cook();
        pasta.Serve();

        Console.ReadKey();
    }
}
