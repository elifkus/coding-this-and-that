using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;
using System.Collections.Generic;

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

        [TestMethod]
        public void TestCalculateOnePathForObstacledBord()
        {
            bool[,] obstacles = new bool[4,4];

            for(int i=0;i<4;i++)
            {
                for(int j=0; j<4; j++)
                {
                    obstacles[i,j] = false;
                }
            }

            obstacles[2,0] = true;
            Problems.Board board = new Problems.Board(4, 4, obstacles);
            List<Tuple<int, int>> list = RecursionAndDynamicProgramming.CalculateOnePathForBoardWithObstacles(board);

            Assert.IsNotNull(list);
            Assert.IsTrue(list.Count > 6);
        }
    }
}
