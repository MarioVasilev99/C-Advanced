namespace CustomComparator_P08
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] evenNums = nums.Where(num => num % 2 == 0).ToArray();
            int[] oddNums = nums.Where(num => num % 2 != 0).ToArray();

            Array.Sort(evenNums);
            Array.Sort(oddNums);

            Action<int[], int[]> print = (x, y) => Console.WriteLine($"{string.Join(" ", x)}" +
                $" {string.Join(" ", y)}");

            print(evenNums, oddNums);
        }
    }
}
