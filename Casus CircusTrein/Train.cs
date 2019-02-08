﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{
    class Train
    {
        public List<Cart> Carts { get; }
        private List<Animal> animals;
        private int wagons;

        public Train()
        {
            Carts = new List<Cart>();
            animals = new List<Animal>();
        }
        public int CalculateCartAmount()
        {
            //Sorts List from big to small
            animals = animals.OrderBy(animal => animal.Size).ToList();
            //Step 1 Add all carnivores to a different cart.
            animals.Where(animal => animal.Diet.Equals(1)).ToList().ForEach((animal => Carts.Add(new Cart(animal, animal.Size))));
            //Step 2 Add all existing herbivores to carts
            foreach (var animal in animals)
            {

                foreach (var cart in Carts)
                {
                    if ((animal.Diet== 0) && ((cart.Animals[0].Size < animal.Size && (cart.Animals[0].Diet == 1) || (cart.Animals[0].Diet == 0)) && ((cart.CurrentCartPoints() + animal.Size <= cart.MaxCarPoints))))
                    {
                        cart.AddAnimalToCart(animal, animal.Size);
                        break;
                    }

                }
                if (IsAnimalInCart(animal) == false)
                {
                    Carts.Add(new Cart(animal, animal.Size));
                }
            }
            wagons = Carts.Count;
            return wagons;
        }

        public bool IsAnimalInCart(Animal animal)
        {
            bool animalInCart = false;

            foreach (Cart cart in Carts)
            {
                if (cart.Animals.Contains(animal))
                {
                    animalInCart = true;
                }
            }
            return animalInCart;
        }

        public void AddAnimal(string name, int size, int diet)
        {
            animals.Add(new Animal(name, size, diet));
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }



        public void ClearLists()
        {
            animals.Clear();
            Carts.Clear();
            wagons = 0;
        }
    }
}