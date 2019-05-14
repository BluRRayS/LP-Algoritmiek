using System;
using System.Collections.Generic;
using System.Linq;
using Casus_Container_Vervoer;
using Casus_Container_Vervoer.Models;
using Casus_Container_Vervoer.Models.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Test_Container_Vervoer.UnitTests
{
    [TestClass]
    public class PlannerUnitTests
    {
        [TestMethod]
        public void TooManyValuableContainersCheckWorksProperlyTest1()
        {
            //Arrange
            var ship = new Ship(2, 4, 100);
            var planner = new Planner(ship);
            for (var i = 0; i < 9 ; i++)
            {
               planner.AddContainer(new Container(0.4, Enums.FreightType.Valuable));
            }
            //Act
            var action = new Action(planner.Plan);

            //Assert
            Assert.ThrowsException<InvalidOperationException>(action);

        }

        [TestMethod]
        public void TooManyValuableContainersCheckWorksProperlyTest2()
        {
            //Arrange
            var ship = new Ship(2, 4, 16);
            var planner = new Planner(ship);
            for (var i = 0; i < 9; i++)
            {
                planner.AddContainer(new Container(1, Enums.FreightType.Valuable));
            }
            //Act
            var action = new Action(planner.Plan);

            //Assert
            Assert.ThrowsException<InvalidOperationException>(action);

        }

        //[TestMethod]
        //public void SumContainerWeightCheckWorksProperlyTest1()
        //{
        //    //Arrange
        //    var ship = new Ship(2, 4, 15);
        //    var planner = new Planner(ship);
        //    for (var i = 0; i < 8; i++)
        //    {
        //        planner.AddContainer(new Container(2, Enums.FreightType.Standard));
        //    }
        //    //Act
        //    var action = new Action(planner.Plan);

        //    //Assert
        //    Assert.ThrowsException<InvalidOperationException>(action);
        //}


        [TestMethod]
        public void TestCase1()
        {
            var ship = new Ship(4,4,30);
            var planner = new Planner(ship);
            
            IList<Container> containers = new List<Container>();

            for (var i = 0; i < 16; i++)
            {
                containers.Add(new Container(30, Enums.FreightType.Cooled));
            }

            for (var i = 0; i < 25; i++)
            {
                containers.Add(new Container(30, Enums.FreightType.Standard));
            }

            for (var i = 0; i < 8; i++)
            {
                containers.Add(new Container(30, Enums.FreightType.Valuable));
            }

            foreach (var container in containers)
            {
                planner.AddContainer(container);
            }

            try
            {
                planner.Plan();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

            var amount = planner.GetShipContainers().Count;
            Assert.IsTrue(planner.GetShipContainers().Count== containers.Count);
        }

        [TestMethod]
        public void TestCase2()
        {
            var ship = new Ship(2, 2, 300);
            var planner = new Planner(ship);

            IList<Container> containers = new List<Container>();

            for (var i = 0; i < 16; i++)
            {
                containers.Add(new Container(30, Enums.FreightType.Standard));
            }

            for (var i = 0; i < 4; i++)
            {
                containers.Add(new Container(20, Enums.FreightType.Standard));
            }

            for (var i = 0; i < 4; i++)
            {
                containers.Add(new Container(5, Enums.FreightType.Standard));
            }

            for (var i = 0; i < 4; i++)
            {
                containers.Add(new Container(5, Enums.FreightType.Standard));
            }

            foreach (var container in containers)
            {
                planner.AddContainer(container);
            }

            try
            {
                planner.Plan();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }

            var amount = planner.GetShipContainers().Count;
            Assert.IsTrue(planner.GetShipContainers().Count == containers.Count);
        }
    }
 }



