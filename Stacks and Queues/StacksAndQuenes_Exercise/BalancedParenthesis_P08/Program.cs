namespace BalancedParenthesis_P08
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> brackets = new Stack<char>();
            List<char> openBrackets = new List<char>()
            {
                '{', '(', '['
            };

            foreach (var symbol in input.ToCharArray())
            {
                if (openBrackets.Contains(symbol))
                {
                    brackets.Push(symbol);
                }
                else
                {
                    if (brackets.Any() == false)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    char lastAddedBracket = brackets.Peek();
                    char closingBracket = symbol;

                    if (lastAddedBracket == '(' && closingBracket == ')' && brackets.Any()
                        || lastAddedBracket == '{' && closingBracket == '}' && brackets.Any()
                        || lastAddedBracket == '[' && closingBracket == ']' && brackets.Any())
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                }
            }

            if (brackets.Count == 0)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
