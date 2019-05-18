namespace FindEvensOrOdd_P04
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] boundaries = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lowerBoundary = boundaries[0];
            int upperBoundary = boundaries[1];

            List<int> numbers = new List<int>();

            for (int i = lowerBoundary; i <= upperBoundary; i++)
            {
                numbers.Add(i);
            }

            string command = Console.ReadLine();

            if (command == "odd")
            {
                Func<int, bool> isOdd = num => num % 2 != 0;

                Action<List<int>> printList = list => list
                .Where(isOdd)
                .Select(x => x + " ")
                .ToList()
                .ForEach(Console.Write);

                printList(numbers);
            }
            else if (command == "even")
            {
                Func<int, bool> isEven = num => num % 2 == 0;

                Action<List<int>> printList = list => list
                .Where(isEven)
                .Select(x => x + " ")
                .ToList()
                .ForEach(Console.Write);

                printList(numbers);
            }
        }
    }
}
