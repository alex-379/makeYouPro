using Zoo.Animals;

namespace Zoo
{
    public class Volieres
    {
        public string Name { get; set; }

        public string Biom { get; private set; }

        public int Square { get; private set; }

        public string Animal { get; private set; }

        public List<AbstractAnimals> Animals { get; private set; }

        public Volieres (string name, string biom, int square, List<AbstractAnimals> animals)
        {
            Name = name;
            Biom = biom;
            Square = square;
            Animals = animals;
        }

        public void AddAnimal(string animal)
        { 
        Animal=animal;

        }
    }
}
