namespace CountSymbols_P05
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            char[] inputSymbols = Console.ReadLine().ToCharArray();

            Dictionary<char, int> symbolCountDict = new Dictionary<char, int>();

            foreach (char symbol in inputSymbols)
            {
                if (symbolCountDict.ContainsKey(symbol))
                {
                    symbolCountDict[symbol]++;
                }
                else
                {
                    symbolCountDict[symbol] = 1;
                }
            }

            foreach (var kvp in symbolCountDict.OrderBy(kvp => kvp.Key))
            {
                char currentSymbol = kvp.Key;
                int timesFound = kvp.Value;

                Console.WriteLine($"{currentSymbol}: {timesFound} time/s");
            }
        }
    }
}
