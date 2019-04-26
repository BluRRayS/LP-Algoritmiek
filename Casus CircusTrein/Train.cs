using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{
    public class Train
    {
        private readonly List<Cart> carts;
        private  List<Animal> animals;

        public Train()
        {
            carts = new List<Cart>();
            animals = new List<Animal>();
        }

        public IReadOnlyCollection<Cart> GetTrainCarts()
        {
            return carts;
        }

        public int CalculateCartAmount()
        {
            AddCarnivoresToCarts(animals.Where(animal => animal.Diet == Enums.Diet.Carnivore));
            foreach (var animal in animals.Where(animal => animal.Diet == Enums.Diet.Herbivore).OrderByDescending(animal=> animal.Size))
            {
                AddAnimalToACart(animal);
            }
            return carts.Count;
        }

        private void AddAnimalToACart(Animal animal)
        {
            
            foreach (var cart in carts)
            {
                if (!cart.AnimalFits(animal)) continue;
                cart.AddAnimalToCart(animal);
                return;
            }
            carts.Add(new Cart(animal));
        }    

        public void AddAnimal(string name, Enums.Size size, Enums.Diet diet)
        {
            animals.Add(new Animal(name, size, diet));
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public IReadOnlyCollection<Animal> GetAnimals()
        {
            return animals;
        }

        public  void ClearLists()
        {
            animals.Clear();
            carts.Clear();
        }

        public void AddCarnivoresToCarts(IEnumerable<Animal> carnivores)
        {
            foreach (var carnivore in carnivores)
            {
                carts.Add(new Cart(carnivore));
            }
        }
    }
}
