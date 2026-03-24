using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Name} ({Age} лет)";
    }
}

static class ArrayUtils
{
    public static void ShuffleArray(Person[] array)
    {
        Random random = new Random();
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            Person temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите количество людей: ");
        int n = int.Parse(Console.ReadLine());

        Person[] people = new Person[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nЧеловек {i + 1}:");
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            people[i] = new Person(name, age);
        }

        Console.WriteLine("\nИсходный массив:");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }

        ArrayUtils.ShuffleArray(people);

        Console.WriteLine("\nПосле перемешивания:");
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }

        Console.ReadKey();
    }
}
