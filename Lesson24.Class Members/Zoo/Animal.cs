namespace Zoo;

public class Animal
{
    public string Name { get; set; }

    public int Volume { get; set; }

    public int Age { get; set; }

    public string Type { get; set; }

    public string Biom { get; set; }

    public int Square { get; set; }

    public string Food { get; set; }

    public string Group { get; set; }

    public string Sound { get; set; }

    public Animal(string name, int volume, int age, string type, string biom, int square, string food, string group, string sound)
    {
        Name = name;
        Volume = volume;
        Age = age;
        Type = type;
        Biom = biom;
        Square = square;
        Food = food;
        Group = group;
        Sound = sound;
    }

    public void DescribeAnimal()
    {
        Console.WriteLine($"{Type} {Name} обитает в биоме {Biom} на площади {Square} м^2.\n" +
                          $"Его возраст в годах - {Age}. Это {Group}.\n" +
                          $"Рацион питания - {Food} в количестве {Volume} кг в сутки.\n" +
                          $"Издаваемый звук - \"{Sound}\".\n");
    }

    public void Eat()
    {
        Console.WriteLine($"{Type} {Name} ест.\n");
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Type} {Name} издаёт звук {Sound}.\n");
    }

    public void Play()
    {
        Console.WriteLine($"{Type} {Name} играет.\n");
    }
}