namespace Zoo.Test;

public class HawkAnimalTests
{
    readonly HawkAnimal hawk = new("Марти");

    [TestCase("Sparrow", -5, 0)]
    [TestCase("Grass", 10, 0)]
    [TestCase("Banana", 10, 0)]
    [TestCase("Sparrow", 20, 20)]
    [TestCase("Sparrow", 35, 55)]
    public void EatHawkTests(string food, int volume, int expected)
    {
        int actual = hawk.Eat(food, volume);

        Assert.That(actual, Is.EqualTo(expected));
    }
}