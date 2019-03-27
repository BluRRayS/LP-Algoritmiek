using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casus_CircusTrein
{
    public class Train
    {
        private List<Cart> carts;
        private List<Animal> animals;

        public Train()
        {
            carts = new List<Cart>();
            animals = new List<Animal>();
        }

        public IReadOnlyCollection<Cart> GetTrainCarts()
        {
            return carts;
        }

        public int CalculateCartAmount(List<Animal> animalsToSort)
        {
            animalsToSort = OrderAnimalsBySize(animalsToSort) as List<Animal>;
            AddEveryCarnivoreToACart(animalsToSort);
            AddHerbivoresToCarts(animalsToSort);
            return carts.Count;
        }

        private static IEnumerable<Animal> OrderAnimalsBySize(IEnumerable<Animal> animals)
        {
            return animals = animals.OrderBy(animal => animal.Size).ToList();
        }

        private void AddEveryCarnivoreToACart(IEnumerable<Animal> animalsToSort)
        {
            animalsToSort.Where(animal => animal.Diet == Enums.Diets.carnivore).ToList()
                        .ForEach(animal => carts.Add(new Cart(animal)));
        }

        private void AddHerbivoresToCarts(IEnumerable<Animal> animalsToSort)
        {
            foreach (var animal in animalsToSort)
            {
                foreach (var cart in carts)
                {
                    if (animal.Diet != 0 || (cart.GetAnimals()[0].Size < animal.Size && cart.GetAnimals()[0].Diet != Enums.Diets.carnivore) &&
                                        cart.GetAnimals()[0].Diet != 0 ||
                                        cart.Points + animal.GetAnimalPoints(animal) > cart.MaxCarPoints) continue;
                    cart.AddAnimalToCart(animal);
                    break;
                }
                if (IsAnimalInCart(animal) == false) carts.Add(new Cart(animal));
            }
        }

        public bool IsAnimalInCart(Animal animal)
        {
            var animalInCart = false;

            foreach (var cart in carts)
                if (cart.GetAnimals().Contains(animal))
                    animalInCart = true;
            return animalInCart;
        }

        public void AddAnimal(string name, Enums.Sizes size, Enums.Diets diet)
        {
            animals.Add(new Animal(name, size, diet));
        }

        public IReadOnlyCollection<Animal> GetAnimals()
        {
            return animals;
        }

        public void ClearLists()
        {
            animals.Clear();
            carts.Clear();
        }

    }
}
