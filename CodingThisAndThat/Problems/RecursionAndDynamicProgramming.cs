using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class RecursionAndDynamicProgramming
    {
        /// <summary>
        /// A robot sitting on the upper left corner of an X by Y grid. The robot can only
        /// move in X and Y directions: right and down. This method calculates the number of 
        /// possible paths the robot can go from (0,0) to (X,Y).
        /// This method only works for x+y < 13. 
        /// </summary>
        public static int CalculatePossiblePathsForRobot(int x, int y)
        { 
            //X times in left, and Y times right
            //All combinations as if each movement were unique
            int allPaths = Factorial(x + y);

            //There are only two types of movements.
            allPaths = allPaths / Factorial(x);
            allPaths = allPaths / Factorial(y);

            return allPaths;
        }

        public static int CalculatePossiblePathsForRobotWithObstacles(int x, int y, int numberOfObstacles)
        {
            int allPaths = CalculatePossiblePathsForRobot(x, y);

            //TODO: Implement

            return allPaths;
        }

        private static int Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
