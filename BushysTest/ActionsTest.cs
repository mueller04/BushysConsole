using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BushysConsole;
namespace BushysConsoleTests
{
    [TestClass]
    public class ActionsTest
    {

        [TestMethod]
        public void WalkTest()
        {
            //Arrange
            
            
            //Act
            Bushy bushy = new Bushy();
            Trail trail = new Trail();
            Actions.Walk(bushy, trail);

            //Assert
            Assert.IsTrue(bushy.health == 1 || bushy.health == 1 || bushy.health == 2 || bushy.health == 3 ||
                bushy.health == 4, "bushy.health was not 0-4, instead it was {0}", bushy.health);
        }

        
    }
}
