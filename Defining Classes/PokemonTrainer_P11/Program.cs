namespace PokemonTrainer_P11
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while (command != "Tournament")
            {
                string[] pokemonData = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = pokemonData[0];
                string pokemonName = pokemonData[1];
                string pokemonElement = pokemonData[2];
                int pokemonHealth = int.Parse(pokemonData[3]);

                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.Any(t => t.Name == trainerName))
                {
                    Trainer existingTrainer = trainers.FirstOrDefault(t => t.Name == trainerName);
                    existingTrainer.Pokemons.Add(newPokemon);
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName, newPokemon);
                    trainers.Add(newTrainer);
                }

                command = Console.ReadLine();
            }

            string inputElement = Console.ReadLine();

            while (inputElement != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == inputElement))
                    {
                        trainer.Badges += 1;
                    }
                    else
                    {
                        for (int i = 0; i < trainer.Pokemons.Count; i++)
                        {
                            Pokemon currentPokemon = trainer.Pokemons[i];

                            currentPokemon.Health -= 10;

                            if (IsDead(currentPokemon.Health))
                            {
                                trainer.Pokemons.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }

                inputElement = Console.ReadLine();
            }

            foreach (var trainer in trainers
                .OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static bool IsDead(int health)
        {
            return health <= 0;
        }
    }
}
