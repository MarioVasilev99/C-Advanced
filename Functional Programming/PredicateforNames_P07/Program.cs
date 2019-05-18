namespace PredicateforNames_P07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int nameMaxLenght = int.Parse(Console.ReadLine());

            Func<string, bool> nameFilter = name => name.Length <= nameMaxLenght;

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(nameFilter)
                .ToList();

            Action<List<string>> print = list => Console.WriteLine($"{string.Join(Environment.NewLine, list)}");

            print(names);
        }
    }
}
