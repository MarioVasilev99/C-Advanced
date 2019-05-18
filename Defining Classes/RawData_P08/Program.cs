namespace RawData_P08
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carData[0];
                int engineSpeed = int.Parse(carData[1]);
                int enginePower = int.Parse(carData[2]);
                int cargoWeigh = int.Parse(carData[3]);
                string cargoType = carData[4];
                double firstTirePressure = double.Parse(carData[5]);
                int firstTireAge = int.Parse(carData[6]);
                double secondTirePressure = double.Parse(carData[7]);
                int secondTireAge = int.Parse(carData[8]);
                double thirdTirePressure = double.Parse(carData[9]);
                int thirdTireAge = int.Parse(carData[10]);
                double fourthTirePressure = double.Parse(carData[11]);
                int fourthTireAge = int.Parse(carData[12]);

                Car newCar = new Car(
                    model,
                    engineSpeed,
                    enginePower,
                    cargoWeigh,
                    cargoType,
                    firstTirePressure,
                    firstTireAge,
                    secondTirePressure,
                    secondTireAge,
                    thirdTirePressure,
                    thirdTireAge,
                    fourthTirePressure,
                    fourthTireAge);

                cars.Add(newCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    bool isFragile = false;

                    var tires = car.Tires;

                    foreach (var tire in tires)
                    {
                        if (tire.Pressure < 1)
                        {
                            isFragile = true;
                            break;
                        }
                    }

                    if (isFragile)
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars.Where(c => c.Engine.Power > 250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
        }
    }
}
