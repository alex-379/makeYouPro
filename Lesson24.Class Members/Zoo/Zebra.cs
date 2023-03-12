namespace Zoo;

public class ZebraAnimal:AbstractAnimal
{
    public ZebraAnimal(string name)
    {
        Name = name;
        Volume = 5;
        Age = 7;
        _type = "Zebra";
        Biom = "Savvana";
        Square = 10;
        Food = "Grass";
        Group = "Herbivorous";
        Sound = "ква-ха";
    }

    public override void Play()
    {
        Console.WriteLine($"{_type} {Name} скачет по савване.\n");
    }
}