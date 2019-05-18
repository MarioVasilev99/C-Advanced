namespace SpeedRacing_P07
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        public Car(string model, double fuel, double fuelConsumption)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;
        }

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double FuelConsumption { get; set; }
        
        public int TravelledDistance { get; set; }

        public void Drive(double distanceToTravel)
        {
            double fuelNeeded = distanceToTravel * this.FuelConsumption;

            if (this.CanDrive(distanceToTravel))
            {
                this.Fuel -= fuelNeeded;
                this.TravelledDistance += (int)distanceToTravel;
            }
        }

        public bool CanDrive(double distanceToTravel)
        {
            double fuelNeeded = distanceToTravel * this.FuelConsumption;

            if (this.Fuel >= fuelNeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
