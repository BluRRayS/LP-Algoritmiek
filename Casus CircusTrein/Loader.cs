using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{
    class Loader
    {
        private List<Cart> carts;
        private List<Animal> animals;
        private List<Animal> animalsToRemove;
        private Animal biggestHerbivore;
        private int carnivoreCount;
        private int herbivoreCount;
        private int animalPoints;
        private int wagons;
        private int maxAnimalSize;

        public Loader()
        {
            carts = new List<Cart>();
            animals = new List<Animal>();
            animalsToRemove = new List<Animal>();
        }
        public int CalculateCartAmount()
        {
            LoadAllCarnivores(); //Step 1 Add all carnivores to a different cart.


            if (carts.Count == 0)//Add a cart if no carnivores are present
            {
                biggestHerbivore = GetBiggestHerbivore();
                animals.Remove(biggestHerbivore);
                carts.Add(new Cart(biggestHerbivore, biggestHerbivore.Size()));
                biggestHerbivore = null;
            }

            while (animals.Count > 0) //Step 2 Add all existing herbivores to carts
            {//step 3 Get the biggest herbivore
                foreach (Animal animal in animals)
                {

                    for (int i = 0; i < carts.Count; i++)//probably bug source
                    {
                        biggestHerbivore = GetBiggestHerbivore();

                        if ((carts.ElementAt(i).CurrentCartPoints() + biggestHerbivore.Size()) <= 10 && biggestHerbivore.Size() > carts.ElementAt(i).GetCarnivoreSize() && carts.ElementAt(i).GetCarnivoreSize() != 0)
                        {
                            carts.ElementAt(i).AddAnimalToCart(biggestHerbivore, biggestHerbivore.Size());
                            animalsToRemove.Add(biggestHerbivore);
                            herbivoreCount++;
                            biggestHerbivore = null;
                        }
                        else if ((carts.ElementAt(i).CurrentCartPoints() + biggestHerbivore.Size()) <= 10 && carts.ElementAt(i).GetCarnivoreSize() == 0)
                        {
                            carts.ElementAt(i).AddAnimalToCart(biggestHerbivore, biggestHerbivore.Size());
                            animalsToRemove.Add(biggestHerbivore);
                            herbivoreCount++;
                            biggestHerbivore = null;
                        }
                        else
                        {
                            carts.Add(new Cart(biggestHerbivore, biggestHerbivore.Size()));
                            animalsToRemove.Add(biggestHerbivore);
                            herbivoreCount++;
                            biggestHerbivore = null;
                        }

                    }
                }
                animals.Clear();
            }
            wagons = carts.Count;
            carts.Clear();
            return wagons;
        }

        public void AddAnimal(string name, int size, bool meatEater)
        {
            animals.Add(new Animal(name, size, meatEater));
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }

        private void LoadAllCarnivores()
        {

            foreach (Animal animal in animals)
            {
                if (animal.Meateater() == true)
                {
                    animalPoints = animal.Size();
                    carts.Add(new Cart(animal, animalPoints));
                    animalsToRemove.Add(animal);
                    carnivoreCount++;
                }
            }
            for (int i = 0; i < carnivoreCount; i++)
            {
                if (animals.Contains(animalsToRemove.ElementAt(i)))
                { animals.Remove(animalsToRemove.ElementAt(i)); }
            }
            animalsToRemove.Clear();

        }

        private Animal GetBiggestHerbivore()
        {
            maxAnimalSize = 0;
            foreach (Animal animal in animals)
            {
                if (maxAnimalSize < animal.Size())
                {
                    biggestHerbivore = animal;
                }
            }
            return biggestHerbivore;
        }

        public void ClearList()
        {
            animals.Clear();
        }
    }
}
