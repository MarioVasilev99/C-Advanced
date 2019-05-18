namespace MatchingBrackets_P04
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<int> bracketsIndexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '(')
                {
                    bracketsIndexes.Push(i);
                }
                else if (currentChar == ')')
                {
                    int startIndex = bracketsIndexes.Pop();
                    int endIndex = i;

                    int lenghtOfSubstring = (endIndex - startIndex) + 1;
                    string brackets = input.Substring(startIndex, lenghtOfSubstring);

                    Console.WriteLine(brackets);
                }
            }
        }
    }
}
