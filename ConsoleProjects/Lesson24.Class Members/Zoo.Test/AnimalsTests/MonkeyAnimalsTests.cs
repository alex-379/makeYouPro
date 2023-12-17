using Zoo.Animals;

namespace Zoo.Test.AnimalsTests;

public class MonkeyAnimalTests
{
    MonkeyAnimals monkey = new("Марти");

    [TestCase("Банан", -10, 0)]
    [TestCase("Трава", 10, 0)]
    [TestCase("Банан", 10, 10)]
    [TestCase("Воробей", 10, 10)]
    [TestCase("Банан", 5, 15)]
    public void EatMonkeyTests(string food, int volume, int expected)
    {
        int actual = monkey.Eat(food, volume);

        Assert.That(actual, Is.EqualTo(expected));
    }
}