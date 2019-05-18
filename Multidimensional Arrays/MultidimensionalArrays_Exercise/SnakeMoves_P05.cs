namespace SnakeMoves_P05
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            char[] snakeArr = Console.ReadLine().ToCharArray();

            int snakeIndex = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = snakeArr[snakeIndex];

                    snakeIndex++;

                    if (snakeIndex > snakeArr.Length - 1)
                    {
                        snakeIndex = 0;
                    }

                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
