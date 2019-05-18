namespace SpeedRacing_P07
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carData[0];
                double fuel = double.Parse(carData[1]);
                double fuelConsumption = double.Parse(carData[2]);

                Car newCar = new Car(model, fuel, fuelConsumption);

                cars.Add(newCar);   
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] splittedCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = splittedCommand[1];
                double distanceToTravel = double.Parse(splittedCommand[2]);

                Car currentCar = cars.Where(c => c.Model == model).FirstOrDefault();

                if (currentCar.CanDrive(distanceToTravel))
                {
                    currentCar.Drive(distanceToTravel);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.Fuel:F2} {car.TravelledDistance:F0}");
            }
        }
    }
}
