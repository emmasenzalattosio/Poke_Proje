using System;
using System.Collections.Generic;

namespace Poke_Proje
{
    public class PokemonCenter
    {
        private List<Pokemon> pokemonList;
        private List<Trainer> trainerList;

        public PokemonCenter()
        {
            pokemonList = new List<Pokemon>();
            trainerList = new List<Trainer>();
        }

        public List<Pokemon> GetAllPokeon()
        {
            return pokemonList;
        }

        public List<Trainer> GetAllTrainers()
        {
            return trainerList;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            if (pokemon == null)
            {
                Console.WriteLine("Kein Pokemon hinzugefügt.");
                return;
            }

            pokemonList.Add(pokemon);
            
        }

        public void AddTrainer(Trainer trainer)
        {
            if (trainer == null)
            {
                Console.WriteLine("Kein Trainer hinzugefügt.");
                return;
            }

            trainerList.Add(trainer);
            ConsoleUI.WriteCentered($"Trainer {trainer.Name} wurde hinzugefügt.");
            Console.Clear();
        }

        public void ShowAllPokemon()
        {
            Console.WriteLine("Alle Pokemon im Center: \n");
            foreach (Pokemon p in pokemonList)
            {
                Console.WriteLine(p.ShowStatus());
            }
        }

        public void ShowAllTrainers()
        {
            ConsoleUI.WriteCentered("Alle Trainer: ");
            Console.WriteLine();
            foreach (Trainer t in trainerList)
            {
                ConsoleUI.WriteCentered($"> {t.Name} ({t.ass_poke.Count} Pokémon)");
            }
        }

        public Pokemon SearchPokemon(string name)
        {
            Pokemon found = null;

            foreach (Pokemon p in pokemonList)
            {
                if (p.Name.ToLower() == name.ToLower())
                {
                    found = p;
                    break;
                }
            }

            if (found != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nGefunden {found.Name}");
                Console.ResetColor();
                Console.WriteLine(found.ShowStatus());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPokemon nicht gefunden");
                Console.ResetColor();
            }

            return found;
        }

        public void AssignPokeon(Pokemon pokemon, Trainer trainer)
        {
            trainer.AssignPokemon(pokemon);
        }

        public void GetBehavior(Pokemon pokemon)
        {
            Console.WriteLine(pokemon.Behavior());
        }

        public void HealPokemon(Pokemon pokemon)
        {
            pokemon.Heal();
        }

        public void HealPokemon(string name)
        {
            Pokemon found = SearchPokemon(name);
            if (found != null)
            {
                found.Heal();
            }
        }

        public bool RemovePokemon(Pokemon pokemon)
        {
            if (pokemonList.Contains(pokemon))
            {
                pokemonList.Remove(pokemon);
                return true;
            }
            return false;
        }
    }
}
