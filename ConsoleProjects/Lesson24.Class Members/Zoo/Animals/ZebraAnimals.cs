namespace Zoo.Animals;

public class ZebraAnimals:AbstractAnimals
{
    public ZebraAnimals(string name)
    {
        Name = name;
        Volume = 5;
        Age = 7;
        Type = "Зебра";
        Biom = "Саввана";
        Square = 10;
        Food = "Трава";
        Group = "Травоядное";
        Sound = "ква-ха";
    }

    public override void Play()
    {
        Console.WriteLine($"{Type} {Name} скачет по савване.\n");
    }
}