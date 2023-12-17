namespace Zoo;

public class Animal
{
    public string Name { get; set; }

    public int Volume { get; private set; }

    public int Age { get; private set; }

    public string Type { get; private set; }

    public string Biom { get; private set; }

    public int Square { get; private set; }

    public string Food { get; private set; }

    public string Group { get; private set; }

    public string Sound { get; private set; }

    private int _sumVolume = 0;
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
        Console.WriteLine($"{Type} {Name} - {Group}. Биом - {Biom}, площадь {Square} м^2.\n" +
                          $"Возраст в годах - {Age}. Рацион питания - {Food} в количестве {Volume} кг в сутки.\n" +
                          $"Издаваемый звук - \"{Sound}\".\n");
    }

    public int Eat(string food, int volume)
    {
        if (food == Food)
        {
            _sumVolume += volume;
        }

        return _sumVolume;
    }

    public void DescribeEat()
    {
        if (_sumVolume == 0)
        {
            Console.WriteLine($"{Type} {Name} не ест такую пищу.\n");
        }
        else if (_sumVolume < Volume)
        {
            Console.WriteLine($"{Type} {Name} ест {Food}. Животное не наелось.\n");
        }
        else
        {
            Console.WriteLine($"{Type} {Name} ест {Food}. Животное сегодня наелось.\n");
        }

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