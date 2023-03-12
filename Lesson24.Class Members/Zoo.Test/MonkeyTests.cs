namespace Zoo.Test;

public class MonkeyAnimalTests
{
    readonly MonkeyAnimal monkey = new("Марти");

    [TestCase("Banana", -10, 0)]
    [TestCase("Grass", 10, 0)]
    [TestCase("Banana", 10, 10)]
    [TestCase("Sparrow", 10, 10)]
    [TestCase("Banana", 5, 15)]
    public void EatMonkeyTests(string food, int volume, int expected)
    {
        int actual = monkey.Eat(food, volume);

        Assert.That(actual, Is.EqualTo(expected));
    }
}