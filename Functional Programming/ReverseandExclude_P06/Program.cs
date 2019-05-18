namespace ReverseandExclude_P06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<int> nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            List<int> finalNumsList = nums.Where(num => num % n != 0).Reverse().ToList();

            Action<List<int>> printList = x => Console.WriteLine($"{string.Join(" ", x)}");

            printList(finalNumsList);
        }
    }
}
