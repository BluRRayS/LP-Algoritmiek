using System;
using System.Collections.Generic;
using System.Net.Configuration;
using Casus_CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CircusTrein_UnitTests
{
    [TestClass]
    public class TrainUnitTest
    {
        [TestMethod]
        public void CartAmountIsCorrectTest1()
        {
            //Arrange
            var cartAmount = 0;
            var train = new Train();
            var animals = new List<Animal>
            {
                new Animal("", Enums.Sizes.Large, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Carnivore),

                new Animal("",Enums.Sizes.Small, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Herbivore),
            };

            //Act
            foreach (var animal in animals)
            {
                train.AddAnimal(animal);
            }
            cartAmount = train.CalculateCartAmount();

            //Assert
            var count = 0;
            foreach (var cart in train.GetTrainCarts())
            {
                foreach (var animal in cart.GetAnimals())
                {
                    Console.WriteLine(animal.ToString() + " | Cart number" + count);
                }

                count++;
            }

            Assert.IsTrue(cartAmount == 7);
        }

        [TestMethod]
        public void CartAmountIsCorrectTest2()
        {
            //Arrange
            var cartAmount = 0;
            var train = new Train();
            var animals = new List<Animal>
            {

                new Animal("",Enums.Sizes.Small, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Herbivore),


                new Animal("", Enums.Sizes.Large, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Herbivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Herbivore),
            };

            //Act
            foreach (var animal in animals)
            {
                train.AddAnimal(animal);
            }

            cartAmount = train.CalculateCartAmount();

            //Assert
            var count = 0;
            foreach (var cart in train.GetTrainCarts())
            {
                foreach (var animal in cart.GetAnimals())
                {
                    Console.WriteLine(animal.ToString() + " | Cart number" + count);
                }

                count++;
            }

            Assert.IsTrue(cartAmount == 7);
        }

        [TestMethod]
        public void CartAmountIsCorrectTest3()
        {
            //Arrange
            var cartAmount = 0;
            var train = new Train();
            var animals = new List<Animal>
            {
                new Animal("", Enums.Sizes.Large, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Large, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Medium, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Carnivore),
                new Animal("", Enums.Sizes.Small, Enums.Diets.Carnivore),

            };

            //Act
            foreach (var animal in animals)
            {
                train.AddAnimal(animal);
            }

            cartAmount = train.CalculateCartAmount();

            //Assert
            var count = 0;
            foreach (var cart in train.GetTrainCarts())
            {
                foreach (var animal in cart.GetAnimals())
                {
                    Console.WriteLine(animal.ToString() + " | Cart number" + count);
                }

                count++;
            }

            Assert.IsTrue(cartAmount == 18);
        }
    }
}
