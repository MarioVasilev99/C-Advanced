namespace PeriodicTable_P03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] elementsToAdd = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in elementsToAdd)
                {
                    elements.Add(element);
                }
            }

            string[] elementArray = elements.ToArray();
            Array.Sort(elementArray);

            foreach (var element in elementArray)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
