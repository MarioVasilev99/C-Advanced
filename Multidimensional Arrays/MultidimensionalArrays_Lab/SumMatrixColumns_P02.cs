namespace SumMatrixColumns
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
                                        .Split(" ")
                                        .Select(int.Parse)
                                        .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    int elementToAdd = elements[col];

                    matrix[row, col] = elementToAdd;
                }
            }

            for (int col = 0; col < cols; col++)
            {
                int columnSum = 0;

                for (int row = 0; row < rows; row++)
                {
                    int currentElement = matrix[row, col];

                    columnSum += currentElement;
                }

                Console.WriteLine(columnSum);
            }
        }
    }
}
