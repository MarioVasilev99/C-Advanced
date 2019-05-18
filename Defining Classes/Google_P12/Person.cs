namespace Google_P12
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person(string name)
        {
            this.Name = name;
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
            this.Pokemons = new List<Pokemon>(); 
        }

        public string Name { get; set; }

        public Car Car { get; set; }

        public Company Company { get; set; }

        public List<Parent> Parents { get; set; }

        public List<Child> Children { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(this.Name);
            result.AppendLine($"Company:");

            if (this.Company != null)
            {
                result.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:F2}");
            }

            result.AppendLine("Car:");

            if (this.Car != null)
            {
                result.AppendLine($"{this.Car.Model} {this.Car.Speed}");
            }

            result.AppendLine($"Pokemon:");
            if (this.Pokemons.Count != 0)
            {
                foreach (var pokemon in this.Pokemons)
                {
                    result.AppendLine($"{pokemon.Name} {pokemon.Type}");
                }
            }

            result.AppendLine($"Parents:");
            if (this.Parents.Count != 0)
            {
                foreach (var parent in this.Parents)
                {
                    result.AppendLine($"{parent.Name} {parent.BirthDate}");
                }
            }

            result.AppendLine($"Children:");
            if (this.Children.Count != 0)
            {
                foreach (var child in this.Children)
                {
                    result.AppendLine($"{child.Name} {child.BirthDay}");
                }
            }

            return result.ToString();
        }
    }
}
