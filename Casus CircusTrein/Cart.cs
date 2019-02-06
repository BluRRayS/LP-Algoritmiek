using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{
    class Cart
    {
        private int points = 0;
        private List<Animal> animals;
        private int maxCarnivoreSize;
        public Cart(Animal animal,int animalPoints)
        {
            animals = new List<Animal>();
            animals.Add(animal);
            points += animalPoints;
        }
    
        public void AddAnimalToCart(Animal animal, int animalPoints)
        {
            animals.Add(animal);
            points += animalPoints;
        }

        public int CurrentCartPoints()
        {
            return points;
        }

        public int GetCarnivoreSize()
        {
            maxCarnivoreSize = 0;
            foreach (Animal animal in animals)
            {
                if (animal.Meateater() == true && maxCarnivoreSize<animal.Size())
                {
                    maxCarnivoreSize = animal.Size();
                }
            }
            return maxCarnivoreSize;
        }
    }
}
