namespace MatrixShuffling_P04
{
    using System;
    using System.Collections.Generic;
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

            // Read the matrix
            for (int row = 0; row < rows; row++)
            {
                string[] elements = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                                        
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = elements[col];
                }
            }

            // Read commands
            while (true)
            {
                string command = Console.ReadLine();

                if (command.ToLower() == "end")
                {
                    break;
                }

                string[] commandParts = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (commandParts.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string action = commandParts[0];
                int row1 = int.Parse(commandParts[1]);
                int col1 = int.Parse(commandParts[2]);
                int row2 = int.Parse(commandParts[3]);
                int col2 = int.Parse(commandParts[4]);

                List<int> coordinates = new List<int>
                {
                    row1, col1, row2, col2
                };

                // Check input coordinates. If correct Swap and Print Matrix
                if (action != "swap"
                    || coordinates.Any(x => x < 0)
                    || row1 >= rows || row2 > rows
                    || col1 >= cols || col2 > cols)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    string firstElement = matrix[row1, col1];

                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = firstElement;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row, col] + " ");
                        }

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
