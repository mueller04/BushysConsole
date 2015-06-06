using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BushysConsole;

namespace BushysTest
{
    [TestClass]
    public class TreeTest
    {
        [TestMethod]
        public void TreeImageTest()
        {
            Tree treetest = new Tree();
            treetest.status = 4;
            treetest.TreeImage(treetest);
        }
    }
}
