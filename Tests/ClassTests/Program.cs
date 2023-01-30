using ClassTests;

string name = "Симба";
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
tiger.Play();