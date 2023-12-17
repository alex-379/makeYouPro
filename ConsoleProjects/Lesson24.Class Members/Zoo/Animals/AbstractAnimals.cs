namespace Zoo.Animals;

public abstract class AbstractAnimals
{
    public string Name { get; set; }

    public int Volume { get; protected set; }

    public int Age { get; protected set; }

    public string Type { get; protected set; }

    public string Biom { get; protected set; }

    public int Square { get; protected set; }

    public string Food { get; protected set; }

    public string Group { get; protected set; }

    public string Sound { get; protected set; }

    protected int _sumVolume = 0;

    public void DescribeAnimal()
    {
        Console.WriteLine($"{Type} {Name} - {Group}. Биом - {Biom}, площадь {Square} м^2.\n" +
                          $"Возраст в годах - {Age}. Рацион питания - {Food} в количестве {Volume} кг в сутки.\n" +
                          $"Издаваемый звук - \"{Sound}\".\n");
    }

    public int Eat(string food, int volume)
    {
        if (volume > 0 && food == Food)
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

    public abstract void Play();
}


