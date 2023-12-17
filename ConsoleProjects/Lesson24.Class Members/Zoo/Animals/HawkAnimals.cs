namespace Zoo.Animals;

public class HawkAnimals : AbstractAnimals
{
    public HawkAnimals(string name)
    {
        Name = name;
        Volume = 8;
        Age = 3;
        Type = "Ястреб";
        Biom = "Тайга";
        Square = 25;
        Food = "Воробей";
        Group = "Хищник";
        Sound = "ки-ки";
    }

    public override void Play()
    {
        Console.WriteLine($"{Type} {Name} машет крыльями.\n");
    }

    public void Fly()
    {
        Console.WriteLine($"{Type} {Name} летает в небе.\n");
    }
}