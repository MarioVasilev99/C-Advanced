namespace PrintEvenNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> evenNums = new Queue<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenNums.Enqueue(num);
                }
            }

            Console.WriteLine($"{string.Join(", ", evenNums)}");
        }
    }
}
