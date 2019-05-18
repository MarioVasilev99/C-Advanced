namespace SquareWithMaximumSum_P05
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] dimensions = Console.ReadLine()
                                      .Split(", ")
                                      .Select(int.Parse)
                                      .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine()
                                      .Split(", ")
                                      .Select(int.Parse)
                                      .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int currentSum = matrix[row, col] +
                                     matrix[row, col + 1] +
                                     matrix[row + 1, col] +
                                     matrix[row + 1, col + 1];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine(
                    "{0} {1}",
                    matrix[bestRow, bestCol],
                    matrix[bestRow, bestCol + 1]);

            Console.WriteLine(
                "{0} {1}",
                matrix[bestRow + 1, bestCol],
                matrix[bestRow + 1, bestCol + 1]);

            Console.WriteLine(bestSum);
        }
    }
}
