namespace GenericSwap_P02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Box<int>> boxes = new List<Box<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int boxValue = int.Parse(Console.ReadLine());

                Box<int> newBox = new Box<int>(boxValue);

                boxes.Add(newBox);
            }

            int[] swapElementIndexes = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstElementIndex = swapElementIndexes[0];
            int secondElementIndex = swapElementIndexes[1];

            SwapListElements(boxes, firstElementIndex, secondElementIndex);

            foreach (var box in boxes)
            {
                Console.WriteLine(box.ToString());
            }
        }

        public static void SwapListElements<T>(List<T> list, int firstPosition, int secondPosition)
        {
            T firstElement = list[firstPosition];
            T secondElement = list[secondPosition];

            list[firstPosition] = secondElement;
            list[secondPosition] = firstElement;
        }
    }
}
