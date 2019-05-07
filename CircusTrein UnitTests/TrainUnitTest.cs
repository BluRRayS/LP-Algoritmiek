using System;
using System.Collections.Generic;
using System.Linq;
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

        [TestMethod]
        public void AnimalCompositionIsCorrectTest1()
        {
            var cartAmount = 0;
            var train = new Train();
            var animals = new List<Animal>
            {
                new Animal("", Enums.Size.Large, Enums.Diet.Herbivore),
                new Animal("", Enums.Size.Large, Enums.Diet.Herbivore),
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
            };

            //Act
            foreach (var animal in animals)
            {
                train.AddAnimal(animal);
            }
            cartAmount = train.CalculateCartAmount();
            var wagons = train.GetTrainCarts().ToList();

            //Assert
            Assert.IsTrue(wagons[0].GetAnimals()[0].Diet == Enums.Diet.Carnivore && wagons[0].GetAnimals()[0].Size == Enums.Size.Large);
            Assert.IsTrue(wagons[0].GetAnimals().Count==1);
            Assert.IsTrue(wagons[1].GetAnimals()[0].Diet == Enums.Diet.Carnivore && wagons[1].GetAnimals()[0].Size == Enums.Size.Large);
            Assert.IsTrue(wagons[1].GetAnimals().Count==1);
            Assert.IsTrue(wagons[2].GetAnimals()[0].Diet == Enums.Diet.Carnivore && wagons[2].GetAnimals()[0].Size == Enums.Size.Medium);
            Assert.IsTrue(wagons[2].GetAnimals()[1].Diet == Enums.Diet.Herbivore && wagons[2].GetAnimals()[1].Size == Enums.Size.Large);
            Assert.IsTrue(wagons[2].GetAnimals().Count == 2);
            Assert.IsTrue(wagons[3].GetAnimals()[0].Diet == Enums.Diet.Carnivore && wagons[3].GetAnimals()[0].Size == Enums.Size.Medium);
            Assert.IsTrue(wagons[3].GetAnimals()[1].Diet == Enums.Diet.Herbivore && wagons[3].GetAnimals()[1].Size == Enums.Size.Large);
            Assert.IsTrue(wagons[3].GetAnimals().Count == 2);
        }
    }
}
