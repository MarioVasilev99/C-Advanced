namespace HotPotato_P06
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string[] children = Console.ReadLine().Split();
            Queue<string> childrenQueue = new Queue<string>(children);

            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            while (childrenQueue.Count > 1)
            {
                string currentChild = childrenQueue.Dequeue();

                if (counter % number != 0)
                {
                    childrenQueue.Enqueue(currentChild);
                }
                else
                {
                    Console.WriteLine($"Removed {currentChild}");
                }

                counter++;
            }

            string lastChild = childrenQueue.Dequeue();
            Console.WriteLine($"Last is {lastChild}");
        }
    }
}
