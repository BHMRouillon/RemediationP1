using Common.AbstractFactory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    [TestClass]
    public class AbstractFactoryUT
    {
        [TestMethod]
        public void TestAbstractFactory()
        {
            // création d'une Factory
            IVehicle warEngine = new WarFactory();
            Client warClient = new Client(warEngine);
            IVehicle civilEngine = new CivilFactory();
            Client civilClient = new Client(civilEngine);

            Assert.AreEqual(2200 , warClient.GetBoatCapacity());
            Assert.AreEqual(1, warClient.GetPlaneCapacity());

           
            Assert.AreEqual(2471, civilClient.GetBoatCapacity());
            Assert.AreEqual(580, civilClient.GetPlaneCapacity());
        }
}
}
