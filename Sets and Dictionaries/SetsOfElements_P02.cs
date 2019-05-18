namespace SetsOfElements_P02
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            int[] setsDimensions = Console.ReadLine()
                                          .Split(" ")
                                          .Select(int.Parse)
                                          .ToArray();

            int firstSetLenght = setsDimensions[0];
            HashSet<int> firstSet = new HashSet<int>();

            int secondSetLenght = setsDimensions[1];
            HashSet<int> secondSet = new HashSet<int>();

            int linesCount = firstSetLenght + secondSetLenght;

            StringBuilder outputSb = new StringBuilder();

            for (int i = 0; i < linesCount; i++)
            {
                int numToAdd = int.Parse(Console.ReadLine());

                if (i < firstSetLenght)
                {
                    firstSet.Add(numToAdd);
                }
                else
                {
                    secondSet.Add(numToAdd);
                }
            }

            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    outputSb.Append(num + " ");
                }
            }

            string output = outputSb.ToString().Trim();

            Console.WriteLine(output);
        }
    }
}
