namespace ClassTests;
public class Animal
{
    public string Name { get; set; }

    public int Volume { get; set; }

    public int Age { get; set; }

    public Animal(string name, int volume, int age)
    {
        Name = name;
        Volume = volume;
        Age = age;
    }

    private string _type = "";
    private string _biom = "";
    private int _square;
    private string _group = "";
    private string _food = "";
    private string _sound = "";

    public void DescribeElefanth()
    {
        _type = "Слон";
        _biom = "тропики";
        _square = 10;
        _group = "травоядное";
        _food = "сено";
        _sound = "Ауф";

        Console.WriteLine($"{_type} {Name} обитает в биоме {_biom} на площади {_square} м^2.\n" +
                          $"Его возраст в годах - {Age}. Это {_group}.\n" +
                          $"Рацион питания - {_food} в количестве {Volume} кг в сутки.\n" +
                          $"Издаваемый звук - \"{_sound}\".\n");
    }

    public void DescribePenguin()
    {
        _type = "Пингвин";
        _biom = "тундра";
        _square = 10;
        _group = "хищник";
        _food = "рыба";
        _sound = "Хрю";

        Console.WriteLine($"{_type} {Name} обитает в биоме {_biom} на площади {_square} м^2.\n" +
                          $"Его возраст в годах - {Age}. Это {_group}.\n" +
                          $"Рацион питания - {_food} в количестве {Volume} кг в сутки.\n" +
                          $"Издаваемый звук - \"{_sound}\".\n");
    }

    public void DescribeTiger()
    {
        _type = "Тигр";
        _biom = "пустыня";
        _square = 10;
        _group = "хищник";
        _food = "рыба и мясо";
        _sound = "Рррр";

        Console.WriteLine($"{_type} {Name} обитает в биоме {_biom} на площади {_square} м^2.\n" +
                          $"Его возраст в годах - {Age}. Это {_group}.\n" +
                          $"Рацион питания - {_food} в количестве {Volume} кг в сутки.\n" +
                          $"Издаваемый звук - \"{_sound}\".\n");
    }

    public void Eat()
    {
        Console.WriteLine($"{_type} {Name} ест.\n");
    }

    public void MakeSound()
    {
        Console.WriteLine($"{_type} {Name} издаёт звук {_sound}.\n");
    }

    public void Play()
    {
        Console.WriteLine($"{_type} {Name} играет.\n");
    }
}