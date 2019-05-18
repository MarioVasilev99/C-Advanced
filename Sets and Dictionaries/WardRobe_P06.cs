namespace WardRobe_P06
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] userInput = Console
                    .ReadLine()
                    .Split(" -> ");

                string color = userInput[0];
                string[] items = userInput[1].Split(",");
            }
        }
    }
}
