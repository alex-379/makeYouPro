namespace Zoo.Animals;

public class MonkeyAnimals : AbstractAnimals
{
    public MonkeyAnimals(string name)
    {
        Name = name;
        Volume = 2;
        Age = 3;
        Type = "Обезьяна";
        Biom = "Тропические леса";
        Square = 8;
        Food = "Банан";
        Group = "Травоядное";
        Sound = "яаа";
    }

    public override void Play()
    {
        Console.WriteLine($"{Type} {Name} прыгает по лианам.\n");
    }

    public void Сrawl()
    {
        Console.WriteLine($"{Type} {Name} взбирается на дерево.\n");
    }

}