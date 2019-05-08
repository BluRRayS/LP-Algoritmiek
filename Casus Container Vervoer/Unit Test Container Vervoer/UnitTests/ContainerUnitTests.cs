using System;
using Casus_Container_Vervoer.Models;
using Casus_Container_Vervoer.Models.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Test_Container_Vervoer
{
    [TestClass]
    public class ContainerUnitTests
    {
        [TestMethod]
        public void ToStringMethodWorksProperly()
        {
            var container = new Container(10,Enums.FreightType.Cooled);
            Assert.IsTrue("FreightType:Cooled | Weight:10" == container.ToString());
        }


    }
}
