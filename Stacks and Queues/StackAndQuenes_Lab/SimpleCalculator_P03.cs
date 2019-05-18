namespace SimpleCalculator_P03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split().Reverse().ToArray();

            Stack<string> expression = new Stack<string>(input);

            int result = int.Parse(expression.Pop());

            while (expression.Any() == true)
            {
                char nextElement = char.Parse(expression.Peek());

                if (nextElement == '+')
                {
                    expression.Pop();

                    int numberToAdd = int.Parse(expression.Pop());
                    result += numberToAdd;
                }
                else if (nextElement == '-')
                {
                    expression.Pop();

                    int numberToSubstract = int.Parse(expression.Pop());
                    result -= numberToSubstract;
                }
            }

            Console.WriteLine(result);
        }
    }
}
