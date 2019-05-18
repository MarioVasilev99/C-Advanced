namespace P03.Stack
{
    using System;

    public class Program
    {
        public static void Main()
        {
            CustomStack<string> stack = new CustomStack<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    foreach (var item in stack)
                    {
                        Console.WriteLine(item);
                    }

                    foreach (var item in stack)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                }

                string[] splittedInput = input.Split(" ", 2);

                string command = splittedInput[0];

                if (command == "Push")
                {
                    string[] elementsToPush = splittedInput[1].Split(", ");

                    foreach (var element in elementsToPush)
                    {
                        stack.Push(element);
                    }
                }
                else if (command == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
