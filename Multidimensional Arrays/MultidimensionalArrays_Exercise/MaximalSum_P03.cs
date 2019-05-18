namespace MaximalSum_P03
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

            int[,] matrix = new int[rows, cols];

            // Read the matrix
            for (int row = 0; row < rows; row++)
            {
                int[] elements = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            // Find 3x3 square with the biggest sum
            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int currentSum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row, col + 2]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1]
                        + matrix[row + 1, col + 2]
                        + matrix[row + 2, col]
                        + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            // Print the best sum
            Console.WriteLine($"Sum = {bestSum}");

            // Print the 3x3 matrix
            // First row
            Console.WriteLine(
                "{0} {1} {2}",
                matrix[bestRow, bestCol],
                matrix[bestRow, bestCol + 1],
                matrix[bestRow, bestCol + 2]);

            // Second row
            Console.WriteLine(
                "{0} {1} {2}",
                matrix[bestRow + 1, bestCol],
                matrix[bestRow + 1, bestCol + 1],
                matrix[bestRow + 1, bestCol + 2]);

            // Third row
            Console.WriteLine(
                "{0} {1} {2}",
                matrix[bestRow + 2, bestCol],
                matrix[bestRow + 2, bestCol + 1],
                matrix[bestRow + 2, bestCol + 2]);

            // END
        }
    }
}
