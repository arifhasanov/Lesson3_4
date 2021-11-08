using System;

namespace Lesson3_4
{
    class Program
    {
        //creating array for the game
        static string[,] doska = new string[10, 10];

        enum Direction
        {
            Down,
            Right
        }

        static void Main(string[] args)
        {
            //filling array with empty characters
            for (int i = 0; i < doska.GetLength(0); i++)
            {
                for (int j = 0; j < doska.GetLength(1); j++)
                {
                    doska[i, j] = ". ";
                }
            }

            //building ships
            GenerateShip(1, 1, 4, Direction.Down);
            GenerateShip(1, 3, 2, Direction.Right);
            GenerateShip(1, 6, 2, Direction.Right);
            GenerateShip(3, 8, 2, Direction.Right);
            GenerateShip(9, 8, 1, Direction.Right);
            GenerateShip(7, 5, 1, Direction.Right);
            GenerateShip(9, 5, 1, Direction.Right);
            GenerateShip(9, 8, 1, Direction.Right);
            GenerateShip(9, 1, 1, Direction.Right);
            GenerateShip(3, 3, 3, Direction.Down);
            GenerateShip(3, 5, 3, Direction.Down);

            //show the game board
            for (int i = 0; i < doska.GetLength(0); i++)
            {
                for (int j = 0; j < doska.GetLength(1); j++)
                {
                    Console.Write(doska[i,j]);
                }
                Console.WriteLine();
            }
        }

        static void GenerateShip(int x, int y, int length, Direction direction)
        {
            if (direction == Direction.Down)
            {
                for (int i = 0; i < length; i++)
                {
                    doska[x + i, y] = "X ";
                }
            }
            else
            {
                for (int i = 0; i < length; i++)
                {
                    doska[x, y + i] = "X ";
                }
            }
        }
    }
}
