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
        private readonly List<Animal> _animals;

        public Cart(Animal animal)
        {
            _animals = new List<Animal>() { animal };
            Points = animal.GetAnimalPoints(animal);
        }

        public int MaxCarPoints { get; } = 10;
        public int Points { get; private set; }

        public IReadOnlyList<Animal> GetAnimals()
        {
            return _animals;
        }

        public void AddAnimalToCart(Animal animal)
        {
            _animals.Add(animal);
            Points += animal.GetAnimalPoints(animal);
        }

        public bool AnimalFits(Animal animalToBeAdded)
        {
            return ((Points + animalToBeAdded.GetAnimalPoints(animalToBeAdded) <= MaxCarPoints) && !(_animals.Any(_animal =>
                        _animal.Diet == Enums.Diets.Carnivore && _animal.Size >= animalToBeAdded.Size)));
        }

    }
}
