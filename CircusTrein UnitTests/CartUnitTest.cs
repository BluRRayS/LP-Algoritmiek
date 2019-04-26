using System;
using Casus_CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrein_UnitTests
{
    [TestClass]
    public class CartUnitTest
    {
        [TestMethod]
        public void CheckIfAnimalFitsWorksProperlyTest()
        {
            //Arrange
            var animal1 = new Animal("LH",Enums.Size.Large,Enums.Diet.Herbivore);
            var animal2 = new Animal("LH", Enums.Size.Large,Enums.Diet.Herbivore);
            var animal3= new Animal("SH", Enums.Size.Small,Enums.Diet.Herbivore);
            var cart = new Cart(animal1);
                
            //Act
            cart.AddAnimalToCart(animal2);

            //Assert
            Assert.IsFalse(cart.AnimalFits(animal3));
            foreach (var animal in cart.GetAnimals())
            {
                Console.WriteLine(animal.ToString());
            }
        }

        [TestMethod]
        public void CheckIfAnimalFitsWorksProperlyTest2()
        {
            //Arrange
            var animal1 = new Animal("LH", Enums.Size.Large, Enums.Diet.Herbivore);
            var animal2 = new Animal("MH", Enums.Size.Medium, Enums.Diet.Herbivore);
            var animal3 = new Animal("SH", Enums.Size.Small, Enums.Diet.Herbivore);
            var cart = new Cart(animal3);

            //Act
            cart.AddAnimalToCart(animal2);

            //Assert
            Assert.IsTrue(cart.AnimalFits(animal1));
            foreach (var animal in cart.GetAnimals())
            {
                Console.WriteLine(animal.ToString());
            }

            
        }

        [TestMethod]
        public void CheckIfPredatorWontBeMergedWithSmallerHerbivore()
        {
            //Arrange
            var predator = new Animal("predator",Enums.Size.Medium,Enums.Diet.Carnivore);
            var herbivore = new Animal("herbivore",Enums.Size.Small,Enums.Diet.Herbivore);
            var cart = new Cart(herbivore);
            //Assert
            foreach (var animal in cart.GetAnimals())
            {
                Console.WriteLine(animal.ToString());
            }
            Assert.IsFalse(cart.AnimalFits(predator));
            
        }
    }
}
