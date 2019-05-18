namespace _2x2SquaresInMatrix_P02
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

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] elements = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            // Find all square matrixes
            int squareMatrixesCount = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    string firstElement = matrix[row, col];
                    string secondElement = matrix[row, col + 1];
                    string thirdElement = matrix[row + 1, col];
                    string fourthElement = matrix[row + 1, col + 1];

                    if (secondElement == firstElement &&
                        thirdElement == firstElement &&
                        fourthElement == firstElement)
                    {
                        squareMatrixesCount++;
                    }
                }
            }

            // Print
            Console.WriteLine(squareMatrixesCount);
        }
    }
}
