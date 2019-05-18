namespace P01.ListyIterator
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            ListyIterator<string> list = null;

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] splittedInput = input.Split();

                string command = splittedInput[0];

                if (command == "Create")
                {
                    list = new ListyIterator<string>(splittedInput.Skip(1).ToList());
                }
                else if (command == "Move")
                {
                    bool hasMoved = list.Move();

                    Console.WriteLine(hasMoved);
                }
                else if (command == "Print")
                {
                    Console.WriteLine($"{list.Print()}");
                }
                else if (command == "HasNext")
                {
                    bool hasNext = list.HasNext();

                    Console.WriteLine(hasNext);
                }
                else if (command == "PrintAll")
                {
                    Console.WriteLine($"{string.Join(" ", list)}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
