namespace JaggedArrayModification_P06
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] currentRow = Console
                    .ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[i] = currentRow;
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command.ToLower() == "end")
                {
                    foreach (var array in jaggedArray)
                    {
                        Console.WriteLine($"{string.Join(" ", array)}");
                    }

                    break;
                }

                string[] commandParts = command.Split();

                string action = commandParts[0];
                int row = int.Parse(commandParts[1]);
                int col = int.Parse(commandParts[2]);
                int value = int.Parse(commandParts[3]);

                if (row < 0
                    || col < 0
                    || row >= jaggedArray.Length
                    || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (action.ToLower() == "add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (action.ToLower() == "subtract")
                {
                    jaggedArray[row][col] -= value;
                }
            }
        }
    }
}
