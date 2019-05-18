namespace FastFood
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] ordersAsArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(ordersAsArray);

            int biggestOrder = orders.Max();

            Console.WriteLine(biggestOrder);

            int ordersCount = orders.Count();

            for (int i = 1; i <= ordersCount; i++)
            {
                int nextOrder = orders.Peek();

                if (foodQuantity - nextOrder >= 0)
                {
                    foodQuantity -= nextOrder;
                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    break;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
