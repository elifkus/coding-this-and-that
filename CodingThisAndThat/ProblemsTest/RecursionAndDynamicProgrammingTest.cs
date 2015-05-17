using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest
{
    [TestClass]
    public class RecursionAndDynamicProgrammingTest
    {
        [TestMethod]
        public void TestCalculatePossiblePathsForRobot()
        {
            int actual = RecursionAndDynamicProgramming.CalculatePossiblePathsForRobot(4, 4);
            Assert.AreEqual(70, actual);
        }
    }
}
