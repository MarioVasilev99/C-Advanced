namespace TraficJam_P07

{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            int carsPassed = 0;

            string userInput = Console.ReadLine();
            while (userInput != "end")
            {
                if (userInput == "green")
                {
                    int carsToPass = Math.Min(n, cars.Count);

                    for (int i = 0; i < carsToPass; i++)
                    {
                        string passedCar = cars.Dequeue();
                        Console.WriteLine($"{passedCar} passed!");

                        carsPassed++;
                    }
                }
                else
                {
                    string carToEnqueue = userInput;

                    cars.Enqueue(carToEnqueue);
                }

                userInput = Console.ReadLine();
            }

            Console.WriteLine($"{carsPassed} cars passed the crossroads.");
        }
    }
}
