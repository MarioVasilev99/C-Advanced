namespace CarSalesman_P10
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine
    {
        private const string DefaultPropertyValue = "n/a";

        public Engine(
            string model,
            int power,
            int displacement,
            string efficinecy)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficinecy;
        }

        public Engine(string model, int power, int displacement) :
            this(model, power, displacement, DefaultPropertyValue)
        {
        }

        public Engine(string model, int power, string efficiency) :
            this(model, power, -1, efficiency)
        {
        }

        public Engine(string model, int power) :
            this(model, power, -1, DefaultPropertyValue)
        {
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

        public override string ToString()
        {
            string displacement = this.Displacement.ToString();

            if (this.Displacement == -1)
            {
                displacement = "n/a";
            }

            StringBuilder result = new StringBuilder();

            result.Append($"{this.Model}:" + Environment.NewLine);
            result.Append($"  Power: {this.Power}" + Environment.NewLine);
            result.Append($"  Displacement: {displacement}" + Environment.NewLine);
            result.Append($"  Efficiency: {this.Efficiency}");

            return result.ToString();
        }
    }
}
