using System.Linq;
using Casus_Container_Vervoer.Models;
using Casus_Container_Vervoer.Models.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Test_Container_Vervoer.UnitTests
{
    [TestClass]
    public class ShipUnitTests
    {
        [TestMethod]
        public void AddsGridToShipCorrectly()
        {
            //Arrange
            const int width = 20;
            const int length = 60;
            const int maxCargoWeight = 1500;           
            const int amountOfPositions = width * length;
            var ship = new Ship(width, length, maxCargoWeight);
            var positions = ship.GetAllPositions().ToList();

            //Assert
            Assert.IsTrue(positions.Count()==amountOfPositions);
            Assert.IsTrue(positions.Count(pos => pos.XPos == 0) == length);
            Assert.IsTrue(positions.Count(pos => pos.YPos == 0) == width);
        }

        [TestMethod]
        public void AddsContainerToShipWorksProperly()
        {
            //Arrange
            const int width = 20;
            const int length = 60;
            const int maxCargoWeight = 1500;
            var ship = new Ship(width, length, maxCargoWeight);
            var container1 = new Container(30,Enums.FreightType.Standard);
            var container2 = new Container(40,Enums.FreightType.Valuable);
            var container3 = new Container(20, Enums.FreightType.Cooled);
            //Act
            ship.AddContainerToShipPosition(container1,0,0);
            ship.AddContainerToShipPosition(container2, 0, 0);
            ship.AddContainerToShipPosition(container3, 0, 0);
            //Assert
            Assert.IsTrue(ship.GetAllPositions().First(pos => pos.GetContainers().Count>0).GetContainers().Count == 3);
        }
    }
}
