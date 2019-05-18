namespace AutoService_P06
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] carsToAdd = Console.ReadLine().Split(" ");

            Queue<string> carsToService = new Queue<string>(carsToAdd);
            Queue<string> carsHistory = new Queue<string>();

            string userInput = Console.ReadLine();

            while (userInput != "End")
            {
                string[] splittedInput = userInput.Split("-");

                string userCommand = splittedInput[0];

                if (userCommand == "Service" && carsToService.Count > 0)
                {
                    string carServiced = carsToService.Dequeue();

                    Console.WriteLine($"Vehicle {carServiced} got served.");

                    carsHistory.Enqueue(carServiced);
                }
                else if (userCommand == "CarInfo")
                {
                    string carSearched = splittedInput[1];

                    if (carsToService.Contains(carSearched))
                    {
                        Console.WriteLine($"Still waiting for service.");
                    }
                    else if (carsHistory.Contains(carSearched))
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (userCommand == "History")
                {
                    string[] servedVehicles = carsHistory.Reverse().ToArray();

                    Console.WriteLine($"{string.Join(", ", servedVehicles)}");
                }
                
                userInput = Console.ReadLine();
            }

            if (carsToService.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carsToService)}");
            }

            string[] carsHistoryArray = carsHistory.Reverse().ToArray();

            Console.WriteLine($"Served vehicles: {string.Join(", ", carsHistoryArray)}");
        }
    }
}
