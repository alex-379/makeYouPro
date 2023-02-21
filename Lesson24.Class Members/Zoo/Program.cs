using Zoo;

Animal[] animals = new Animal[]
    {
    new Animal ("Марти", 5, 7, "Зебра", "саввана", 10, "трава", "травоядное", "Ква-ха"),
    new Animal ("Алекс", 7, 4, "Лев", "степь", 50, "мясо", "хищник", "ррр"),
    new Animal ("Джулиан", 30, 5, "Жираф", "пустыня", 20, "листья акации", "травоядное", "х-ы-ы"),
    new Animal ("Рико", 2, 20, "Пингвин", "тундра", 5, "рыба", "хищник", "кря"),
    };

for (int i = 0;i < animals.Length; i++)
{
    animals[i].DescribeAnimal();
    animals[i].Play();
    animals[i].MakeSound();
    animals[i].Eat("листья акации", 1);
    animals[i].Eat("мясо", 10);
    animals[i].Eat("листья акации", 29);
    animals[i].Eat("рыба", 1);
    animals[i].DescribeEat();
}
