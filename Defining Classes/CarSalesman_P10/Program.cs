namespace CarSalesman_P10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            // Initialise Engines 
            for (int i = 0; i < n; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineData[0];
                int power = int.Parse(engineData[1]);

                if (engineData.Length == 4)
                {
                    int displacement = int.Parse(engineData[2]);
                    string efficiency = engineData[3];

                    Engine newEngine = new Engine(model, power, displacement, efficiency);

                    engines.Add(newEngine);
                }
                else if (engineData.Length == 2)
                {
                    Engine newEngine = new Engine(model, power);

                    engines.Add(newEngine);
                }
                else
                {
                    string unknownElement = engineData[2];

                    if (int.TryParse(unknownElement, out int displacement))
                    {
                        Engine newEngine = new Engine(model, power, displacement);

                        engines.Add(newEngine);
                    }
                    else
                    {
                        string efficiency = unknownElement;

                        Engine newEngine = new Engine(model, power, efficiency);

                        engines.Add(newEngine);
                    }
                }
            }

            // Initialise CARS
            int m = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < m; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carData[0];
                string engineModel = carData[1];
                Engine carEngine = engines.Where(e => e.Model == engineModel).FirstOrDefault();

                if (carData.Length == 4)
                {
                    int weight = int.Parse(carData[2]);
                    string color = carData[3];

                    Car newCar = new Car(model, carEngine, weight, color);

                    cars.Add(newCar);
                }
                else if (carData.Length == 2)
                {
                    Car newCar = new Car(model, carEngine);

                    cars.Add(newCar);
                }
                else
                {
                    string unknownProperty = carData[2];

                    if (int.TryParse(unknownProperty, out int weight))
                    {
                        Car newCar = new Car(model, carEngine, weight);

                        cars.Add(newCar);
                    }
                    else
                    {
                        string color = unknownProperty;
                        Car newCar = new Car(model, carEngine, color);

                        cars.Add(newCar);
                    }
                }
            }

            // PRINT CARS
            foreach (var car in cars)
            {
                string carDisplacement = car.Engine.Displacement.ToString();

                if (carDisplacement == "-1")
                {
                    carDisplacement = "n/a";
                }

                string carWeight = car.Weight.ToString();

                if (carWeight == "-1")
                {
                    carWeight = "n/a";
                }

                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {carDisplacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {carWeight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
            
        }
    }
}
