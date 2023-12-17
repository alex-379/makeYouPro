using Zoo.Animals;

namespace Zoo.Test.AnimalsTests;

public class ZebraAnimalsTests
{
    ZebraAnimals zebra = new("Марти");

    [TestCase("Банан", -15, 0)]
    [TestCase("Трава", 50, 50)]
    [TestCase("Банан", 10, 50)]
    [TestCase("Воробей", 20, 50)]
    [TestCase("Воробей", 35, 50)]
    public void EatZebraTests(string food, int volume, int expected)
    {
        int actual = zebra.Eat(food, volume);

        Assert.That(actual, Is.EqualTo(expected));
    }
}