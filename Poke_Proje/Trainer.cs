using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class Trainer
    {
        public string name { get; set; }
        public List<Pokemon> ass_poke { get; set; }

        // constructor
        // btw made everything public because I am too lazy to write the getter and setter for long >:C

        public Trainer(string name)
        {
            this.name = name;
            this.ass_poke = new List<Pokemon>();
        }

        public void AssignPokemon(Pokemon pokemon)
        {
            // pretty self explanatory right??
            // check if trainer has enough pokemon
            // wanna add more?? ya can´t lol
            if (ass_poke.Count >= 5)
            {
                Console.WriteLine($"{name} too many pokes, chill mal brudi");
                return;
            }

            // if not enough poke and gg wp add the new monster
            ass_poke.Add(pokemon);
            Console.WriteLine($"{pokemon.Name} got this b ass trainer: {name}.");
        }

        public void ShowPokemon()
        {
            // really?? do I need to explain this?? wthhhh
            Console.WriteLine($"Trainer {name}: Pokemon ");
            if (ass_poke.Count == 0)
            {
                Console.WriteLine("No Pokemon assigned yet.");
                return;
            }

            foreach (Pokemon p in ass_poke)
            {
                Console.WriteLine(p.ShowStatus());
            }
        }
    }
}
