using System;

abstract class Worker
{
    public string Name { get; set; }

    public Worker(string name)
    {
        Name = name;
    }

    public abstract void DoWork();
}

class Welder : Worker
{
    public Welder(string name) : base(name) { }

    public override void DoWork()
    {
        Console.WriteLine($"Сварщик {Name} выполняет сварочные работы");
    }
}

class Assembler : Worker
{
    public Assembler(string name) : base(name) { }

    public override void DoWork()
    {
        Console.WriteLine($"Сборщик {Name} собирает детали");
    }
}

class Electrician : Worker
{
    public Electrician(string name) : base(name) { }

    public override void DoWork()
    {
        Console.WriteLine($"Электрик {Name} проводит электромонтажные работы");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите количество рабочих: ");
        int n = int.Parse(Console.ReadLine());

        Worker[] workers = new Worker[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nРабочий {i + 1}:");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Выберите профессию (1 - Сварщик, 2 - Сборщик, 3 - Электрик): ");
            int type = int.Parse(Console.ReadLine());

            switch (type)
            {
                case 1:
                    workers[i] = new Welder(name);
                    break;
                case 2:
                    workers[i] = new Assembler(name);
                    break;
                case 3:
                    workers[i] = new Electrician(name);
                    break;
                default:
                    workers[i] = new Welder(name);
                    break;
            }
        }

        Console.WriteLine("\n=== Выполнение работ ===");
        foreach (var worker in workers)
        {
            worker.DoWork();
        }

        Console.ReadKey();
    }
}
