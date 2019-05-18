namespace TronRacers
{
    using System;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            int firstPlayerRow = -1;
            int firstPlayerCol = -1;

            int secondPlayerRow = -1;
            int secondPlayerCol = -1;

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();

                if (currentRow.Contains('f'))
                {
                    int firstPlayerIndex = Array.IndexOf(currentRow, 'f');

                    firstPlayerCol = firstPlayerIndex;
                    firstPlayerRow = row;
                }

                if (currentRow.Contains('s'))
                {
                    int secondPlayerIndex = Array.IndexOf(currentRow, 's');

                    secondPlayerCol = secondPlayerIndex;
                    secondPlayerRow = row;
                }

                matrix[row] = currentRow;
            }

            bool playerDied = false;

            while (playerDied != true)
            {
                string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                // MOVE FIRST PLAYER
                string firstPlayerCommand = commands[0];

                int[] firstPlayerNewCoordinates = GetMovedPlayerCoordinates(firstPlayerRow, firstPlayerCol, firstPlayerCommand, matrix, rows);

                firstPlayerRow = firstPlayerNewCoordinates[0];
                firstPlayerCol = firstPlayerNewCoordinates[1];

                // MOVE SECONDPLAYER
                string secondPlayerCommand = commands[1];

                var newCoordinates = GetMovedPlayerCoordinates(secondPlayerRow, secondPlayerCol, secondPlayerCommand, matrix, rows);

                secondPlayerRow = newCoordinates[0];
                secondPlayerCol = newCoordinates[1];

                // CHECK IF SOMEBODY DIES
                if (matrix[firstPlayerRow][firstPlayerCol] == 's')
                {
                    playerDied = true;

                    matrix[firstPlayerRow][firstPlayerCol] = 'x';
                    break;
                }
                else
                {
                    matrix[firstPlayerRow][firstPlayerCol] = 'f';
                }

                if (matrix[secondPlayerRow][secondPlayerCol] == 'f')
                {
                    playerDied = true;

                    matrix[secondPlayerRow][secondPlayerCol] = 'x';
                }
                else
                {
                    matrix[secondPlayerRow][secondPlayerCol] = 's';
                }
            }

            for (int row = 0; row < rows; row++)
            {
                char[] currentRow = matrix[row];

                if (row == rows - 1)
                {
                    Console.Write($"{string.Join("", currentRow)}");
                }
                else
                {
                    Console.WriteLine($"{string.Join("", currentRow)}");
                }
            }
        }

        public static int[] GetMovedPlayerCoordinates(int playerRow, int playerCol, string command, char[][] matrix, int rows)
        {
            switch (command.ToLower())
            {
                case "up":
                    if (playerRow - 1 >= 0)
                    {
                        playerRow -= 1;
                    }
                    else if (playerRow == 0)
                    {
                        playerRow = rows - 1;
                    }
                    break;

                case "down":
                    if (playerRow < rows - 1)
                    {
                        playerRow += 1;
                    }
                    else if (playerRow == rows - 1)
                    {
                        playerRow = 0;
                    }
                    break;

                case "left":
                    if (playerCol > 0)
                    {
                        playerCol -= 1;
                    }
                    else if (playerCol == 0)
                    {
                        playerCol = matrix[playerCol].Length - 1;
                    }
                    break;

                case "right":
                    if (playerCol < matrix[playerCol].Length - 1)
                    {
                        playerCol += 1;
                    }
                    else if (playerCol == matrix[playerCol].Length - 1)
                    {
                        playerCol = 0;
                    }
                    break;
            }

            int[] movedPlayerCoordinates = new int[]
            {
                playerRow, playerCol
            };

            return movedPlayerCoordinates;
        }
    }
}
