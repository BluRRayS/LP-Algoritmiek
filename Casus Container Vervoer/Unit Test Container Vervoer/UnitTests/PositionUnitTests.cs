using Casus_Container_Vervoer.Models;
using Casus_Container_Vervoer.Models.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Test_Container_Vervoer.UnitTests
{
    [TestClass]
    public class PositionUnitTests
    {
        [TestMethod]
        public void WeightAfterAddingContainerIsCorrect()
        {
            //Arrange
            var container1 = new Container(30, Enums.FreightType.Standard);
            var container2 = new Container(29, Enums.FreightType.Cooled);
            var position = new Position(0, 0);
            //Act
            position.AddContainer(container1);
            position.AddContainer(container2);

            //Assert
            Assert.IsTrue(position.Weight == container1.Weight + container2.Weight);
        }

        [TestMethod]
        public void GetsAllContainersCorrectly()
        {
            var container1 = new Container(30, Enums.FreightType.Standard);
            var container2 = new Container(30, Enums.FreightType.Valuable);
            var container3 = new Container(30, Enums.FreightType.Standard);
            var container4 = new Container(30, Enums.FreightType.Standard);
            var container5 = new Container(30, Enums.FreightType.Standard);
            var position = new Position(0, 0);

            position.AddContainer(container1);
            position.AddContainer(container2);
            position.AddContainer(container3);
            position.AddContainer(container4);
            position.AddContainer(container5);

            Assert.IsTrue(position.GetContainers().Count == 5);
        }

        [TestMethod]
        public void GetPositionWeightCorrectlyTest1()
        {
            var container1 = new Container(30, Enums.FreightType.Standard);
            var container2 = new Container(30, Enums.FreightType.Valuable);
            var position = new Position(0, 0);

            position.AddContainer(container1);
            position.AddContainer(container2);

            Assert.IsTrue(position.GetPositionWeight() == 30.0);
        }

        [TestMethod]
        public void PositionWeightChecksWorksCorrectlyTest1()
        {
            //MaxWeight spot = 120
            var container2 = new Container(30, Enums.FreightType.Standard);
            var container3 = new Container(90, Enums.FreightType.Standard);
            var position = new Position(0, 0);

            position.AddContainer(container2);

            Assert.IsTrue(position.TryAddContainer(container3));

        }

        [TestMethod]
        public void PositionWeightChecksWorksCorrectlyTest2()
        {
            //MaxWeight spot = 120
            var container1 = new Container(120,Enums.FreightType.Standard);
            var container2 = new Container(30, Enums.FreightType.Standard);
            var container3 = new Container(90, Enums.FreightType.Standard);
            var container4 = new Container(100,Enums.FreightType.Standard);
            var position = new Position(0, 0);

            position.AddContainer(container1);
            position.AddContainer(container2);

            Assert.IsTrue(position.TryAddContainer(container3));
            Assert.IsFalse(position.TryAddContainer(container4));
        }

        [TestMethod]
        public void GetPositionWeightWorksCorrectlyTest2() 
        {
            //MaxWeight spot = 120
            var container1 = new Container(120, Enums.FreightType.Standard);
            var container2 = new Container(30, Enums.FreightType.Standard);
            var position = new Position(0, 0);

            position.AddContainer(container1);
            position.AddContainer(container2);

            Assert.IsTrue(position.GetPositionWeight() == 30.0);
        }

    }
}