namespace Zoo;

public class MonkeyAnimal : AbstractAnimal
{
    public MonkeyAnimal(string name)
    {
        Name = name;
        Volume = 2;
        Age = 3;
        _type = "Monkey";
        Biom = "Tropical forests";
        Square = 8;
        Food = "Banana";
        Group = "Herbivorous";
        Sound = "яаа";
    }

    public override void Play()
    {
        Console.WriteLine($"{_type} {Name} прыгает по лианам.\n");
    }

    public void Сrawl()
    {
        Console.WriteLine($"{_type} {Name} взбирается на дерево.\n");
    }

}