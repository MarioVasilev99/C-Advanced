namespace PrimaryDiagonal_P03
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] elements = Console.ReadLine()
                                        .Split(" ")
                                        .Select(int.Parse)
                                        .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            int diagonalSum = 0;

            for (int i = 0; i < size; i++)
            {
                int currentRow = i;
                int currentCol = i;

                diagonalSum += matrix[currentRow, currentCol];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}
