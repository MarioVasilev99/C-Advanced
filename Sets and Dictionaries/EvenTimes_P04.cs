namespace EvenTimes_P04
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbersCount = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int numToAdd = int.Parse(Console.ReadLine());

                if (numbersCount.ContainsKey(numToAdd))
                {
                    numbersCount[numToAdd]++;
                }
                else
                {
                    numbersCount[numToAdd] = 1;
                }
            }

            foreach (var kvp in numbersCount)
            {
                int number = kvp.Key;
                int count = kvp.Value;

                if (count % 2 == 0)
                {
                    Console.WriteLine(number);

                    break;
                }
            }
        }
    }
}
