namespace PokemonTrainer_P11
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Trainer
    {
        public Trainer(string name, Pokemon newPokemon)
        {
            this.Name = name;
            this.Pokemons = new List<Pokemon>();

            this.Pokemons.Add(newPokemon);
        }

        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemons { get; set; }
    }
}
