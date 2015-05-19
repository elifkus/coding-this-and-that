using System;
using System.Collections;
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

        public static List<Tuple<int,int>> CalculateOnePathForBoardWithObstacles(Board board)
        {
            List<Tuple<int, int>> path = new List<Tuple<int, int>>();

            Tuple<int, int> current = new Tuple<int, int>(0,0);
            path.Add(current);

            while(current.Item1 != board.X || current.Item2 != board.Y)
            {
                current = CalculateNextTile(current.Item1, current.Item2, board);

                if (current != null)
                {
                    path.Add(current);
                }
                else
                {
                    throw new Exception("Path does not exist");
                }
            }

            return path;
        }

        private static Tuple<int,int> CalculateNextTile(int x, int y, Board board)
        {
            if(x == board.X && y == board.Y)
            {
                return new Tuple<int,int>(x,y);
            }
            else
            {
                if (x < board.X && board.IsTileAccessible(x+1, y))
                {
                    return new Tuple<int, int>(x+1, y);
                    
                }
                else if (y<board.Y && board.IsTileAccessible(x,y+1))
                {
                    return new Tuple<int, int>(x, y + 1);
                }
            }

            return null;
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

    public class Board
    {
        public int x;
        public int X
        {
            get { return x; }
        }
        private int y;
        public int Y
        {
            get { return y; }
        }
        private bool[,] obstacleExists;

        public Board(int x, int y, bool[,] obstacles)
        {
            this.x = x - 1;
            this.y = y - 1;
            this.obstacleExists = obstacles;
        }

        public bool IsTileAccessible(int x, int y)
        {
            if (x > this.x || y > this.y)
            {
                throw new ArgumentOutOfRangeException("The tile is out of the board");
            }

            return !obstacleExists[x, y];
        }
    }
}
