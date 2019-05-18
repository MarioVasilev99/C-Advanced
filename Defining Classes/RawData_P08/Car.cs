namespace RawData_P08
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        public Car(
            string carModel,
            int engineSpeed,
            int enginePower,
            int cargoWeight,
            string cargoType,
            double firstTirePressure,
            int firstTireAge,
            double secondTirePressure,
            int secondTireAge,
            double thirdTirePressure,
            int thirdTireAge,
            double fourthTirePressure,
            int fourthTireAge)
        {
            this.Model = carModel;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeight, cargoType);
            this.Tires.Add(new Tire(firstTireAge, firstTirePressure));
            this.Tires.Add(new Tire(secondTireAge, secondTirePressure));
            this.Tires.Add(new Tire(thirdTireAge, thirdTirePressure));
            this.Tires.Add(new Tire(fourthTireAge, fourthTirePressure));
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public List<Tire> Tires { get; set; } = new List<Tire>();
    }
}
