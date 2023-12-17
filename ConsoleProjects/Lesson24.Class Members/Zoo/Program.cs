using Zoo;
using Zoo.Animals;

List<AbstractAnimals> animals = new()
{
    new ZebraAnimals ("Марти"),
    new HawkAnimals ("Рико"),
    new MonkeyAnimals ("Джулия")
};

List<Volieres> volieres = new()
{
new Volieres ("Вольер", "Саввана", 50, animals )
};

for (int i = 0; i < animals.Count; i++)
{
    animals[i].DescribeAnimal();
}

for (int i = 0;i < 1; i++)
{
    Console.WriteLine(volieres[i]);
}
    ZebraAnimals zebra = new("Марти");
zebra.DescribeAnimal();
//zebra.Eat("Трава", 5);
//zebra.DescribeEat();
//zebra.MakeSound();
//zebra.Play();

HawkAnimals hawk = new("Рико");
hawk.DescribeAnimal();
//hawk.Eat("Sparrow", 10);
//hawk.DescribeEat();
//hawk.MakeSound();
//hawk.Play();
//hawk.Fly();

MonkeyAnimals monkey = new("Джулия");
monkey.DescribeAnimal();
//monkey.Eat("Banana", 1);
//monkey.DescribeEat();
//monkey.MakeSound();
//monkey.Play();
//monkey.Сrawl();
