namespace CarSalesman_P10
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Car
    {
        private const string DefaultPropertyValue = "n/a";

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight) :
            this(model, engine, weight, DefaultPropertyValue)
        {
        }

        public Car(string model, Engine engine, string color) :
            this(model, engine, -1, color)
        {
        }

        public Car(string model, Engine engine) :
            this(model, engine, -1, DefaultPropertyValue)
        {
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            string weight = this.Weight.ToString();

            if (this.Weight == -1)
            {
                weight = "n/a";
            }

            result.Append($"{this.Model}:" + Environment.NewLine);
            result.Append($"  {this.Engine.ToString()}" + Environment.NewLine);
            result.Append($"  Weight: {this.Weight}" + Environment.NewLine);
            result.Append($"  Color: {this.Color}");

            return result.ToString();
        }
    }
}
