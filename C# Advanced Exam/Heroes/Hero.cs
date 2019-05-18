namespace Heroes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Hero
    {
        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public Item Item { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Hero: {this.Name} – {this.Level}lvl");
            result.AppendLine($" Item:");
            result.AppendLine($"  * Strength: {this.Item.Strength}");
            result.AppendLine($"  * Ability: {this.Item.Ability}");
            result.Append($"  * Intelligence: {this.Item.Intelligence}");

            return result.ToString();
        }
    }
}
