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
                new Animal("", Enums.Size.Large, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Carnivore),

                new Animal("",Enums.Size.Small, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Herbivore),
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

                new Animal("",Enums.Size.Small, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Herbivore),


                new Animal("", Enums.Size.Large, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Herbivore),
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
                new Animal("", Enums.Size.Large, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Medium, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Carnivore),
                new Animal("", Enums.Size.Small, Enums.Diet.Carnivore),

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
