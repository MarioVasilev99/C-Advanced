namespace FashionBoutique_P05
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] clothesInTheBox = Console.ReadLine()
                                           .Split()
                                           .Select(int.Parse)
                                           .ToArray();

            Stack<int> box = new Stack<int>(clothesInTheBox);

            int rackCapacity = int.Parse(Console.ReadLine());

            int rackCount = 1;

            int currentRackSum = 0;

            for (int i = 1; i <= box.Count; i++)
            {
                int cloth = box.Peek();

                if (currentRackSum + cloth <= rackCapacity)
                {
                    currentRackSum += cloth;
                    box.Pop();
                    i--;
                }
                else
                {
                    rackCount++;
                    currentRackSum = 0;

                    currentRackSum += cloth;
                    box.Pop();
                    i--;
                }
            }

            Console.WriteLine(rackCount);
        }
    }
}
