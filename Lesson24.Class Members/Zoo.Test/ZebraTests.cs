namespace Zoo.Test;

public class ZebraAnimalTests
{
    readonly ZebraAnimal zebra = new("Марти");

    [TestCase("Grass", -15, 0)]
    [TestCase("Grass", 50, 50)]
    [TestCase("Banana", 10, 50)]
    [TestCase("Sparrow", 20, 50)]
    [TestCase("Sparrow", 35, 50)]
    public void EatZebraTests(string food, int volume, int expected)
    {
        int actual = zebra.Eat(food, volume);

        Assert.That(actual, Is.EqualTo(expected));
    }
}