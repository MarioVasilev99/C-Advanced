namespace SumMatrixElements_P01
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

            int matrixSum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] colElements = Console.ReadLine()
                                           .Split(", ")
                                           .Select(int.Parse)
                                           .ToArray();
                matrixSum += colElements.Sum();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(matrixSum);
        }
    }
}
