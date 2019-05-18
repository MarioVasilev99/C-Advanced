namespace ActionPoint_P01
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Action<List<string>> printNames = Print;

            printNames(names);
        }

        public static void Print(List<string> list)
        {
            list.ForEach(Console.WriteLine);
        }
    }
}
