namespace MaximumAndMinimumElement_P03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Stack<int> sequence = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int mainCommand = commands[0];

                if (mainCommand == 1)
                {
                    int numberToPush = commands[1];

                    sequence.Push(numberToPush);
                }
                else if (sequence.Count != 0)
                {
                    if (mainCommand == 2)
                    {
                        sequence.Pop();
                    }
                    else if (mainCommand == 3)
                    {
                        int sequenceMaxElement = sequence.Max();

                        Console.WriteLine(sequenceMaxElement);
                    }
                    else if (mainCommand == 4)
                    {
                        int sequenceMinElement = sequence.Min();

                        Console.WriteLine(sequenceMinElement);
                    }
                }
            }
          
            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
