namespace PascalTriangle_P07
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long rows = long.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[rows][];

            pascalTriangle[0] = new long[1];
            pascalTriangle[0][0] = 1;

            for (int row = 1; row < rows; row++)
            {
                pascalTriangle[row] = new long[row + 1];

                pascalTriangle[row][0] = 1;

                long lastIndex = pascalTriangle[row].Length - 1;

                pascalTriangle[row][lastIndex] = 1;

                long cols = pascalTriangle[row].Length;

                for (int col = 1; col < cols - 1; col++)
                {
                    pascalTriangle[row][col] = pascalTriangle[row - 1][col] +
                                               pascalTriangle[row - 1][col - 1];
                }
            }

            foreach (var row in pascalTriangle)
            {
                Console.WriteLine($"{string.Join(" ", row)}");
            }
        }
    }
}
