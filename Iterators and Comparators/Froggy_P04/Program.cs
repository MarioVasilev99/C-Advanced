namespace P04.Froggy
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var stones = Console
                .ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            Path<int> frogPath = new Path<int>(stones);

            Console.WriteLine($"{string.Join(", ", frogPath)}");
        }
    }
}
