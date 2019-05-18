namespace BasicQueneOperations_P02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int s = input[1];
            int x = input[2];

            int[] numbersToEnqueue = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbersQueue = new Queue<int>(numbersToEnqueue);

            for (int i = 0; i < s; i++)
            {
                numbersQueue.Dequeue();
            }

            if (numbersQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (numbersQueue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                int queueMinNum = numbersQueue.Min();
                Console.WriteLine(queueMinNum);
            }
        }
    }
}
