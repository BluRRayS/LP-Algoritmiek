using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casus_CircusTrein
{
    public class Cart
    {
        private readonly List<Animal> animals;

        public Cart(Animal animal)
        {
            animals = new List<Animal>(){animal};
            Points = animal.GetAnimalPoints(animal);
        }

        public int MaxCarPoints { get; } = 10;
        public int Points { get; private set; }

        public IReadOnlyList<Animal> GetAnimals()
        {
            return animals;
        }

        public void AddAnimalToCart(Animal animal)
        {
            animals.Add(animal);
            Points += animal.GetAnimalPoints(animal);
        }

        public bool AnimalFits(Animal animal)
        {
            return Points + animal.GetAnimalPoints(animal) <= 10;
        }

    }
}
