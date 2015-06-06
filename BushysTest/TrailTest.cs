using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BushysConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace BushysConsoleTests
{
    [TestClass()]
    public class TrailTest
    {
        [TestMethod()]
        public void TrailTestConstructor()
        {
            //Arrange
            Trail testtrail = new Trail();
            int expectedmoves = 6;
            int expectedNutsRequired = 2;
            int expectedTrailNumber = 0;
 
            //Act
            int actualMoves = testtrail.moves;
            int actualNutsRequired = testtrail.nutsRequired;
            int actualTrailNumber = testtrail.trailNumber;

            //Assert
            Assert.AreEqual(expectedmoves, actualMoves);
            Assert.AreEqual(expectedNutsRequired, actualNutsRequired);
            Assert.AreEqual(expectedTrailNumber, actualTrailNumber);
        }


        [TestMethod()]
        public void newLevelTest()
        {
            //Arrange
            Trail testtrail = new Trail();
            int expectedtrailNumber = 1;
            int expectedMoves = 4;
            int expectedNuts = 3;

            //Act
            testtrail.newLevel();
            int actualTrailNumber = testtrail.trailNumber;
            int actualMoves = testtrail.moves;
            int actualNuts = testtrail.nutsRequired;

            //Assert
            Assert.AreEqual(expectedtrailNumber, actualTrailNumber);
            Assert.AreEqual(expectedMoves, actualMoves);
            Assert.AreEqual(expectedNuts, actualNuts);
        }

        //test that level 1 can be initialized then level 2 can be initalized with even greater values
        [TestMethod()]
        public void newLevelTest2()
        {
            //Arrange
            Trail testtrail = new Trail();
            int expectedtrailNumber = 2;
            int expectedMoves = 5;
            int expectedNuts = 4;

            //Act
            testtrail.newLevel();
            testtrail.newLevel();
            int actualTrailNumber = testtrail.trailNumber;
            int actualMoves = testtrail.moves;
            int actualNuts = testtrail.nutsRequired;

            //Assert
            Assert.AreEqual(expectedtrailNumber, actualTrailNumber);
            Assert.AreEqual(expectedMoves, actualMoves);
            Assert.AreEqual(expectedNuts, actualNuts);
        }

    }
}
