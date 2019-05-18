namespace RadioactiveMutantVampireBunnies_P10
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            int[] dimensions = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] lair = new char[rows, cols];

            List<Bunny> bunnies = new List<Bunny>();

            for (int row = 0; row < rows; row++)
            {
                char[] elements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    char elementToAdd = elements[col];

                    if (elementToAdd == 'B')
                    {
                        var newBunny = new Bunny(row, col);

                        bunnies.Add(newBunny);
                    }

                    lair[row, col] = elements[col];
                }
            }

            char[] commands = Console.ReadLine().ToCharArray();

            // Last Known Player Position && Did player Won/Lost
            int lastPlayerRow = -1;
            int lastPlayerCol = -1;

            bool playerDied = false;
            bool playerWon = false;

            // Game Start
            foreach (char command in commands)
            {
                // Search For Player
                int[] playerCoordinates = FindPlayer(lair, rows, cols);

                // Player Coordinates
                int playerRow = playerCoordinates[0];
                int playerCol = playerCoordinates[1];

                // Move Player
                switch (command)
                {
                    // Move RIGHT
                    case 'R':   

                        if (playerCol + 1 <= cols - 1)
                        {
                            char rightCell = lair[playerRow, playerCol + 1];

                            // Player LOSES
                            if (rightCell == 'B')  
                            {
                                playerDied = true;
                                lastPlayerRow = playerRow;
                                lastPlayerCol = playerCol + 1;
                            }
                            else
                            {
                                lair[playerRow, playerCol + 1] = 'P';
                                lair[playerRow, playerCol] = '.';
                            }
                        }
                        // Player WINS
                        else if (playerCol + 1 > cols - 1) 
                        {
                            lair[playerRow, playerCol] = '.';

                            playerWon = true;
                            lastPlayerRow = playerRow;
                            lastPlayerCol = playerCol;
                        }

                        break;

                    // Move LEFT
                    case 'L':   

                        if (playerCol - 1 >= 0)
                        {
                            char leftCell = lair[playerRow, playerCol - 1];

                            // Player LOSES
                            if (leftCell == 'B') 
                            {
                                playerDied = true;
                                lastPlayerRow = playerRow;
                                lastPlayerCol = playerCol - 1;
                            }
                            else
                            {
                                lair[playerRow, playerCol - 1] = 'P';
                                lair[playerRow, playerCol] = '.';
                            }
                        }
                        // Player WINS
                        else if (playerCol - 1 < 0) 
                        {
                            lair[playerRow, playerCol] = '.';

                            playerWon = true;
                            lastPlayerRow = playerRow;
                            lastPlayerCol = playerCol;
                        }
                        break;

                    // Move UP
                    case 'U':  

                        if (playerRow - 1 >= 0)
                        {
                            char upperCell = lair[playerRow - 1, playerCol];

                            if (upperCell == 'B')
                            {
                                playerDied = true;
                                lastPlayerRow = playerRow - 1;
                                lastPlayerCol = playerCol;
                            }
                            else
                            {
                                lair[playerRow - 1, playerCol] = 'P';
                                lair[playerRow, playerCol] = '.';
                            }
                        }
                        else if (playerRow - 1 < 0)
                        {
                            lair[playerRow, playerCol] = '.';

                            playerWon = true;
                            lastPlayerRow = playerRow;
                            lastPlayerCol = playerCol;
                        }
                        break;

                    case 'D':
                        if (playerRow + 1 <= rows - 1)
                        {
                            char lowerCell = lair[playerRow + 1, playerCol];

                            if (lowerCell == 'B')
                            {
                                playerDied = true;
                                lastPlayerRow = playerRow + 1;
                                lastPlayerCol = playerCol;
                            }
                            else
                            {
                                lair[playerRow + 1, playerCol] = 'P';
                                lair[playerRow, playerCol] = '.';
                            }
                        }
                        else if (playerRow + 1 > rows - 1)
                        {
                            lair[playerRow, playerCol] = '.';

                            playerWon = true;
                            lastPlayerRow = playerRow;
                            lastPlayerCol = playerCol;
                        }
                        break;
                }

                // Spread The Bunnies
                List<Bunny> tempBunnies = new List<Bunny>(bunnies); 

                foreach (var bunny in tempBunnies)
                {
                    // Spread RIGHT
                    if (bunny.Col + 1 <= cols - 1)
                    {
                        char rightCell = lair[bunny.Row, bunny.Col + 1];

                        if (rightCell == 'P' && playerDied == false)
                        {
                            playerDied = true;

                            lastPlayerRow = bunny.Row;
                            lastPlayerCol = bunny.Col + 1;
                        }

                        lair[bunny.Row, bunny.Col + 1] = 'B';

                        Bunny newBunny = new Bunny(bunny.Row, bunny.Col + 1);
                        bunnies.Add(newBunny);
                    }

                    // Spread Left
                    if (bunny.Col - 1 >= 0)
                    {
                        char leftCell = lair[bunny.Row, bunny.Col - 1];

                        if (leftCell == 'P' && playerDied == false)
                        {
                            playerDied = true;

                            lastPlayerRow = bunny.Row;
                            lastPlayerCol = bunny.Col - 1;
                        }

                        lair[bunny.Row, bunny.Col - 1] = 'B';

                        Bunny newBunny = new Bunny(bunny.Row, bunny.Col - 1);
                        bunnies.Add(newBunny);
                    }

                    // Spread UP
                    if (bunny.Row - 1 >= 0)
                    {
                        char upperCell = lair[bunny.Row - 1, bunny.Col];

                        if (upperCell == 'P' && playerDied == false)
                        {
                            playerDied = true;

                            lastPlayerRow = bunny.Row - 1;
                            lastPlayerCol = bunny.Col;
                        }

                        lair[bunny.Row - 1, bunny.Col] = 'B';

                        Bunny newBunny = new Bunny(bunny.Row - 1, bunny.Col);
                        bunnies.Add(newBunny);
                    }

                    // Spread DOWN
                    if (bunny.Row + 1 <= rows - 1)
                    {
                        char bottomCell = lair[bunny.Row + 1, bunny.Col];

                        if (bottomCell == 'P' && playerDied == false)
                        {
                            playerDied = true;

                            lastPlayerRow = bunny.Row + 1;
                            lastPlayerCol = bunny.Col;
                        }

                        lair[bunny.Row + 1, bunny.Col] = 'B';

                        Bunny newBunny = new Bunny(bunny.Row + 1, bunny.Col);
                        bunnies.Add(newBunny);
                    }
                }

                if (playerDied || playerWon)
                {
                    break;
                }
            }

            // OUTPUT
            PrintLair(lair);

            if (playerDied)
            {
                Console.WriteLine($"dead: {lastPlayerRow} {lastPlayerCol}");
            }
            else if (playerWon)
            {
                Console.WriteLine($"won: {lastPlayerRow} {lastPlayerCol}");
            }
        }

        private static void PrintLair(char[,] lair)
        {
            StringBuilder lairToPrint = new StringBuilder();

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    char elementToAdd = lair[row, col];

                    lairToPrint.Append(elementToAdd);
                }

                if (row != lair.GetLength(0) - 1)
                {
                    lairToPrint.Append(Environment.NewLine);
                }
            }

            Console.WriteLine(lairToPrint);
        }

        private static int[] FindPlayer(char[,] lair, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    char currentElement = lair[row, col];

                    //Found Player

                    if (currentElement == 'P')
                    {
                        int[] coordinates = new int[]
                        {
                            row, col
                        };

                        return coordinates;
                    }
                }
            }

            return null;
        }
    }

    public class Bunny
    {
        public Bunny(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }

        public int Col { get; set; }
    }
}
