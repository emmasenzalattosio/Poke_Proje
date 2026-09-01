using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{

    // this class is there to just be the middle man between dealer and customer 
    // calling all methods to trigger actions
    public class PokemonCenter
    {
        private List<Pokemon> pokemonList;
        private List<Trainer> trainerList;

        public PokemonCenter()
        {
            pokemonList = new List<Pokemon>();
            trainerList = new List<Trainer>();
        }

        // method MAKES SURE YOU ADD FK pokeons
        public void AddPokemon(Pokemon pokemon)
        {
            pokemonList.Add(pokemon);
            Console.WriteLine($"{pokemon.Name} was added to the Pokemon Center.");
        }

        // same thing pokeons
        public void AddTrainer(Trainer trainer)
        {
            trainerList.Add(trainer);
            Console.WriteLine($"Trainer {trainer.name} was added.");
        }

        public void ShowAllPokemon()
        {
            // also self explanatory righttt???
            // goes through all the pokeon list and show status
            Console.WriteLine("All Pokemon in the Center: ");
            foreach (Pokemon p in pokemonList)
            {
                Console.WriteLine(p.ShowStatus());
            }
        }

        public void ShowAllTrainers()
        {
            // you got it?? same concept for trainers
            Console.WriteLine("All Trainers: ");
            foreach (Trainer t in trainerList)
            {
                Console.WriteLine(t.name);
            }
        }

        public Pokemon SearchPokemon(string name)
        {
            // starting point null nada nothing niente
            Pokemon found = null;

            // loops through every pokeon in list
            // if found maches p then gg WELL DONE you found
            // name parameter eingabe = name in list -- got it??
            foreach (Pokemon p in pokemonList)
            {
                if (p.Name.ToLower() == name.ToLower())
                {
                    found = p;
                    break; // if found exit loop so no need to check everything
                }
            }
            // no match?? your prob bihh

            if (found == null)
                Console.WriteLine("Pokemon not found.");

            // if match then return match, if no match return shit ok????
            return found; 
        }

        // gets pokeon and give it to trainer, need both parameters from objekts to mitch match
        public void AssignPokeon(Pokemon pokemon, Trainer trainer)
        {
            trainer.AssignPokemon(pokemon);
        }

        // do I need to explain??
        public void GetBehavior(Pokemon pokemon)
        {
            Console.WriteLine(pokemon.Behavior());
        }

        public void HealPokemon(Pokemon pokemon)
        {
            pokemon.Heal();
        }


    }
}
