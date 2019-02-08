using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{
    class Cart
    {
        public static int CartNumber = 0;
        private int points = 0;
        private int maxCarnivoreSize;

        public Cart(Animal animal,int animalPoints)
        {
            CartNumber += 1;
            Animals = new List<Animal> {animal};
            points += animalPoints;
        }

        public List<Animal> Animals { get; set; }

        public int MaxCarPoints { get; } = 10;

        public void AddAnimalToCart(Animal animal, int animalPoints)
        {
            Animals.Add(animal);
            points += animalPoints;
        }

        public int GetCartNumber()
        {
            return CartNumber;
        }



        public int CurrentCartPoints()
        {
            return points;
        }

        public int GetCarnivoreSize()
        {
            maxCarnivoreSize = 0;
            foreach (var animal in Animals)
            {
                if (animal.Diet == 1&& maxCarnivoreSize<animal.Size)
                {
                    maxCarnivoreSize = animal.Size;
                }
            }
            return maxCarnivoreSize;
        }
    }
}
