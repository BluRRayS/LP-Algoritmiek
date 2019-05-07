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
            //return ((Points + animalToBeAdded.GetAnimalPoints(animalToBeAdded) <= MaxCarPoints) && !(_animals.Any(animal =>
            //animal.Diet == Enums.Diet.Carnivore && animal.Size >= animalToBeAdded.Size)));

            if (animalToBeAdded.Diet == Enums.Diet.Herbivore)
            {
                return (Points + animalToBeAdded.GetAnimalPoints(animalToBeAdded) <= MaxCarPoints)
                       && !(_animals.OrderByDescending(animal => animal.Diet)
                           .Any(animal => animal.Diet == Enums.Diet.Carnivore && animal.Size >= animalToBeAdded.Size));
            }
            else if (animalToBeAdded.Diet == Enums.Diet.Carnivore && _animals.Any(animal => animal.Diet == Enums.Diet.Carnivore))
            {
                return false;
            }

            return false;

            //return (animalToBeAdded.Diet == Enums.Diet.Carnivore && !_animals.Any(animal => animal.Diet == Enums.Diet.Carnivore) && !_animals.Any(animal => animal.Diet == Enums.Diet.Herbivore && animal.Size < animalToBeAdded.Size));

        }

    }
}
