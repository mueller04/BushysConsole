using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BushysConsole;

namespace BushysTest
{
    [TestClass]
    public class BushyTest
    {
        [TestMethod]
        public void BushyConstructorTest()
        {

            //Arrange
            Bushy bushytest = new Bushy();

            int expectedhealth = 1;
            int expectednuts = 0;

            //Act
            int actualhealth = bushytest.health;
            int actualnuts = bushytest.nuts;


            //Assert
            Assert.AreEqual(expectedhealth, actualhealth);
            Assert.AreEqual(expectednuts, actualnuts);
        }

        [TestMethod]
        public void getHealthTest()
        {

            //Arrange
            Bushy bushytest = new Bushy();

            string expected = "Fair";

            //Act
            bushytest.health = 2;
            string actual = bushytest.GetHealth();

            //Assert
            Assert.AreEqual(expected, actual);

        }


    }
}
