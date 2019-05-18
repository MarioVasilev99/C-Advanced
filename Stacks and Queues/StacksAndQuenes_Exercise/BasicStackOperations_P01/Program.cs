namespace BasicStackOperations_P01
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int s = input[1];
            int x = input[2];

            int[] numbersToPush = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(numbersToPush);

            for (int i = 0; i < s; i++)
            {
                numbers.Pop();
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minNum = numbers.Min();
                Console.WriteLine(minNum);
            }
        }
    }
}
