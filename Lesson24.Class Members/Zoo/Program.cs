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