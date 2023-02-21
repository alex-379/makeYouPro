namespace Zoo.Test;

public class AnimalTests
{
    Animal zebra = new Animal("�����", 5, 7, "�����", "�������", 10, "�����", "����������", "���-��");

    [TestCase("�����", 10, 0)]
    [TestCase("�����", 10, 10)]
    [TestCase("����", 10, 10)]
    [TestCase("�����", 5, 15)]
    public void EatZebraTests(string food, int volume, int expected)
    {
        int actual = zebra.Eat(food, volume);

        Assert.That(actual, Is.EqualTo(expected));
    }

    Animal lion = new Animal("�����", 7, 4, "���", "�����", 50, "����", "������", "���");

    [TestCase("������", 10, 0)]
    [TestCase("�����", 10, 0)]
    [TestCase("����", 10, 10)]
    [TestCase("�����", 5, 10)]
    public void EatLionTests(string food, int volume, int expected)
    {
        int actual = lion.Eat(food, volume);

        Assert.That(actual, Is.EqualTo(expected));
    }
}