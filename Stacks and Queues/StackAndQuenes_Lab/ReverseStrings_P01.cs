namespace ReverseStrings
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> inputStack = new Stack<char>(input);

            foreach (char symbol in inputStack)
            {
                Console.Write(symbol);
            }
        }
    }
}
