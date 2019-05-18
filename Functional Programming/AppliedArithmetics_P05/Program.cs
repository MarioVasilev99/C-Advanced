namespace AppliedArithmetics_P05
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var nums = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Func<int, int> add = num => num += 1;
            Func<int, int> multiply = num => num *= 2;
            Func<int, int> subtract = num => num -= 1;

            Action<List<int>> print = list => Console.WriteLine($"{string.Join(" ", list)}");

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                switch (command)
                {
                    case "add":
                        nums = nums.Select(add).ToList();
                        break;

                    case "multiply":
                        nums = nums.Select(multiply).ToList();
                        break;

                    case "subtract":
                        nums = nums.Select(subtract).ToList();
                        break;

                    case "print":
                        print(nums);
                        break;
                }
            }
        }
    }
}
