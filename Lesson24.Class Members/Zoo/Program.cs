using Zoo;

Animal animal = new ("Melman", 30, 20, "жираф", "саввана", 10, "листья акации", "травоядное", "х-ы-ы");
animal.DescribeAnimal();

animal.Play();
animal.Eat();
animal.MakeSound();

animal.Type = "кордофанский жираф";
animal.Name = "Африка";
animal.Biom = "тропический лес";
animal.DescribeAnimal();
animal.Eat();


























/*string name = "Симба";
int volume = 50;
int age = 20;
Animal elefanth = new(name, volume, age);
elefanth.DescribeElefanth();


name = "Петя";
volume = 5;
age = 1;
Animal penguin = new(name, volume, age);
penguin.DescribePenguin();

name = "Матильда";
volume = 10;
age = 5;
Animal tiger = new(name, volume, age);
tiger.DescribeTiger();


tiger.Eat();
penguin.MakeSound();
elefanth.Play();

elefanth.Eat();
tiger.MakeSound();
penguin.Play();

penguin.Eat();
elefanth.MakeSound();
tiger.Play();*/