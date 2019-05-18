namespace ListOfPredicates_P09
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            var dividers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            HashSet<int> uniqueDividers = new HashSet<int>();

            foreach (var num in dividers)
            {
                uniqueDividers.Add(num);
            }

            var divisibleNumbers = new List<int>();

            Func<int, int, bool> isDivisible = (num, divider) => num % divider == 0;

            foreach (var divider in uniqueDividers)
            {
                var numsToAdd = numbers.Where(num => isDivisible(num, divider)).ToList();

                divisibleNumbers.AddRange(numsToAdd);
            }

            Action<List<int>> print = list => list.ForEach(Console.Write);

            print(divisibleNumbers);
        }
    }
}
