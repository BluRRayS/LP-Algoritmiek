using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{
    class Cart
    {
        private static int cartNumber = 0;
        private int points = 0;

        public Cart(Animal animal,int animalPoints)
        {
            cartNumber += 1;
            Animals = new List<Animal> {animal};
            points += animalPoints;
        }

        private List<Animal> Animals { get; set; }

        public IReadOnlyList<Animal> GetAnimals()
        {
            return Animals;
        }

        public int MaxCarPoints { get; } = 10;

        public void AddAnimalToCart(Animal animal, int animalPoints)
        {
            Animals.Add(animal);
            points += animalPoints;
        }

        public int GetCartNumber()
        {
            return cartNumber;
        }

        public int CurrentCartPoints()
        {
            return points;
        }
    }
}
