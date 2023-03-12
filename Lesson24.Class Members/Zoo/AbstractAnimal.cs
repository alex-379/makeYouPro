namespace Zoo;

public abstract class AbstractAnimal
{
    public string Name { get; set; }

    public int Volume { get; set; }

    public int Age { get; set; }

    protected string _type { get; set; }

    public string Biom { get; set; }

    public int Square { get; set; }

    public string Food { get; set; }

    public string Group { get; set; }

    public string Sound { get; set; }

    protected int _sumVolume = 0;

    public void DescribeAnimal()
    {
        Console.WriteLine($"{_type} {Name} - {Group}. Биом - {Biom}, площадь {Square} м^2.\n" +
                          $"Возраст в годах - {Age}. Рацион питания - {Food} в количестве {Volume} кг в сутки.\n" +
                          $"Издаваемый звук - \"{Sound}\".\n");
    }

    public int Eat(string food, int volume)
    {
        if (volume < 0)
        {
            volume = 0;
        }
        else if (food == Food)
        {
            _sumVolume += volume;
        }

        return _sumVolume;
    }

    public void DescribeEat()
    {
        if (_sumVolume == 0)
        {
            Console.WriteLine($"{_type} {Name} не ест такую пищу.\n");
        }
        else if (_sumVolume < Volume)
        {
            Console.WriteLine($"{_type} {Name} ест {Food}. Животное не наелось.\n");
        }
        else
        {
            Console.WriteLine($"{_type} {Name} ест {Food}. Животное сегодня наелось.\n");
        }

    }

    public void MakeSound()
    {
        Console.WriteLine($"{_type} {Name} издаёт звук {Sound}.\n");
    }

    public abstract void Play();
}


