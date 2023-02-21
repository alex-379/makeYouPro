namespace Zoo.Test;

public class AnimalTests
{
    Animal zebra = new Animal("Марти", 5, 7, "Зебра", "саввана", 10, "трава", "травоядное", "Ква-ха");

    [TestCase("листь", 10, 0)]
    [TestCase("трава", 10, 10)]
    [TestCase("мясо", 10, 10)]
    [TestCase("трава", 5, 15)]
    public void EatZebraTests(string food, int volume, int expected)
    {
        int actual = zebra.Eat(food, volume);

        Assert.That(actual, Is.EqualTo(expected));
    }

    Animal lion = new Animal("Алекс", 7, 4, "Лев", "степь", 50, "мясо", "хищник", "ррр");

    [TestCase("листья", 10, 0)]
    [TestCase("трава", 10, 0)]
    [TestCase("мясо", 10, 10)]
    [TestCase("трава", 5, 10)]
    public void EatLionTests(string food, int volume, int expected)
    {
        int actual = lion.Eat(food, volume);

        Assert.That(actual, Is.EqualTo(expected));
    }
}