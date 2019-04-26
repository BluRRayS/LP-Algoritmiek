using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Casus_CircusTrein;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrein_UnitTests
{
    [TestClass]
    public class AnimalUnitTest
    {
        [TestMethod]
        public void GetsAnimalPointsCorrectly()
        {
            //Arrange
            var animal1 = new Animal("smallAnimal",Enums.Size.Small,Enums.Diet.Herbivore);
            var animal2 = new Animal("MediumAnimal", Enums.Size.Medium, Enums.Diet.Carnivore);
            var animal3 = new Animal("smallAnimal", Enums.Size.Large, Enums.Diet.Herbivore);
            var animal1Points = 0;
            var animal2Points = 0;
            var animal3Points = 0;

            //Act
            animal1Points = animal1.GetAnimalPoints(animal1);
            animal2Points = animal2.GetAnimalPoints(animal2);
            animal3Points = animal3.GetAnimalPoints(animal3);

            //Assert
            Assert.IsTrue(animal1Points==1 && animal2Points ==3 && animal3Points ==5);
        }

        [TestMethod]
        public void ToStringWorksProperly()
        {
            //Arrange
            var animal = new Animal("Lion",Enums.Size.Medium,Enums.Diet.Carnivore);
            var toString =""; 

            //Act
            toString = animal.ToString();

            //Assert
            Assert.IsTrue(toString=="Lion:"+Enums.Diet.Carnivore+":"+Enums.Size.Medium.ToString());
        }
    }
}
