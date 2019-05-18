namespace Supermarket_P05
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Queue<string> customers = new Queue<string>();
            string userInput = Console.ReadLine();

            while (userInput != "End")
            {
                if (userInput == "Paid")
                {
                    for (int i = 1; i <= customers.Count; i++)
                    {
                        string customerToDequeue = customers.Dequeue();
                        i--;
                        Console.WriteLine(customerToDequeue);
                    }
                }
                else
                {
                    customers.Enqueue(userInput);
                }

                userInput = Console.ReadLine();
            }

            int customersRemaining = customers.Count;
            Console.WriteLine($"{customersRemaining} people remaining.");
        }
    }
}
