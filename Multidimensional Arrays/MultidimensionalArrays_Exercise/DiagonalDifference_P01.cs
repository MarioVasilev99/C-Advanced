namespace DiagonalDifference_P01
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            // Primary Diagonal
            int primaryDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonal += matrix[i, i];
            }

            // Secondary Diagonal
            int secondaryDiagonal = 0;

            int secondaryRow = n - 1;
            int secondaryCol = 0;

            for (int i = 0; i < n; i++)
            {
                secondaryDiagonal += matrix[secondaryRow, secondaryCol];

                secondaryRow--;
                secondaryCol++;
            }

            // Difference
            int diff = primaryDiagonal - secondaryDiagonal;

            // Print
            Console.WriteLine(Math.Abs(diff));
        }
    }
}
