namespace CustomMinFunction_P03
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Func<int, int> filter = x => x;

            List<int> nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(nums.Min());
        }
    }
}
