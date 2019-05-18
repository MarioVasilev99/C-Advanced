namespace KnightsofHonor_P02
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Func<string, string> addTitle = name => $"Sir {name}";

            var names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(addTitle)
                .ToList();

            names.ForEach(Console.WriteLine);
        }
    }
}
