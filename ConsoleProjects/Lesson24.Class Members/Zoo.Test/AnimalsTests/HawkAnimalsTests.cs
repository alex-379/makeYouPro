using Zoo.Animals;

namespace Zoo.Test.AnimalsTests;

public class HawkAnimalTests
{
    HawkAnimals hawk = new("Марти");

    [TestCase("Воробей", -5, 0)]
    [TestCase("Трава", 10, 0)]
    [TestCase("Банан", 10, 0)]
    [TestCase("Воробей", 20, 20)]
    [TestCase("Воробей", 35, 55)]
    public void EatHawkTests(string food, int volume, int expected)
    {
        int actual = hawk.Eat(food, volume);

        Assert.That(actual, Is.EqualTo(expected));
    }
}