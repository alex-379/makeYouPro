namespace Zoo;

public class HawkAnimal : AbstractAnimal
{
    public HawkAnimal(string name)
    {
        Name = name;
        Volume = 8;
        Age = 3;
        _type = "Hawk";
        Biom = "Taiga";
        Square = 25;
        Food = "Sparrow";
        Group = "Predator";
        Sound = "ки-ки";
    }

    public override void Play()
    {
        Console.WriteLine($"{_type} {Name} машет крыльями.\n");
    }

    public void Fly()
    {
        Console.WriteLine($"{_type} {Name} летает в небе.\n");
    }
}