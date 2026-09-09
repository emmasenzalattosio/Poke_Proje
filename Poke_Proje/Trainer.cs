using System;
using System.Collections.Generic;
using System.Linq;

namespace Poke_Proje
{
    public class Trainer
    {
        public string Name;
        public List<Pokemon> ass_poke { get; set; }

        public Trainer(string name)
        {
            this.Name = name;
            this.ass_poke = new List<Pokemon>();
        }

        private int ReadNumber(int min, int max)
        {
            int result;

            while (true)
            {
                Console.Write($"Enter a number ({min}-{max}): ");
                if (int.TryParse(Console.ReadLine(), out result) && result >= min && result <= max)
                    return result;

                Console.WriteLine("Invalid, try again.");
            }
        }

        public Pokemon? ChoosePokemonFromTeam()
        {
            if (ass_poke.Count == 0)
            {
                ConsoleUI.WriteCentered($"{Name} has no Pokémon in the team.");
                return null;
            }

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ConsoleUI.WriteCentered(@"   ___  _______   _____  _____  ___    _______________ ______________
  / _ \/ __/ _ | / _ \ \/ /__ \/__ \  / __/  _/ ___/ // /_  __/ / / /
 / , _/ _// __ |/ // /\  / /__/ /__/ / _/_/ // (_ / _  / / / /_/_/_/ 
/_/|_/___/_/ |_/____/ /_/ (_)  (_)  /_/ /___/\___/_//_/ /_/ (_|_|_)  
                                                                     ");
            ConsoleUI.WriteCentered($"═════════ {Name}'s team ═════════");
            Console.WriteLine();

            for (int i = 0; i < ass_poke.Count; i++)
            {
                ConsoleUI.WriteCentered($"[{i + 1}] {ass_poke[i].Name} - HP: {ass_poke[i].GetCurrentHp()}/{ass_poke[i].GetMaxHp()}");
            }

            int choice = ReadNumber(1, ass_poke.Count);
            return ass_poke[choice - 1];
        }

        public void AssignPokemon(Pokemon pokemon)
        {
            pokemon.SetTrainer(Name);
            ass_poke.Add(pokemon);
            Console.WriteLine();
        }

        public void 
            ShowPokemon()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            ConsoleUI.WriteCentered($"=== {Name}'s Pokémon ===");

            if (ass_poke.Count == 0)
            {
                ConsoleUI.WriteCentered("No Pokémon assigned yet.");
                ConsoleUI.WriteCentered("\nPress any key to return to the menu...");
                Console.ReadKey(true);
                return;
            }


            Ascii ascii = new Ascii();
            foreach (Pokemon p in ass_poke)
            {
                ascii.ShowArt(p.Name);
                Console.WriteLine("                                                         ════════════════════════════════════════════════════════════════════════════════════");
                ConsoleUI.WriteCentered(p.ShowStatus());
                Console.WriteLine("                                                         ═════════════════════════════════════════════════════════════════════════════════════");
                ConsoleUI.WriteCentered(p.Behavior());
                Console.WriteLine("                                                         ═════════════════════════════════════════════════════════════════════════════════════");
                Console.WriteLine();
            }

            ConsoleUI.WriteCentered("Press any key to return to the menu...");
            Console.ReadKey(true);
        }

        public void HealPokemon(Pokemon pokemon)
        {
            if (pokemon == null)
            {
                Console.WriteLine("No Pokémon was selected for healing.");
                return;
            }

            pokemon.Heal();
            Console.WriteLine($"{Name} healed {pokemon.Name}.");
            Console.WriteLine($"HP: {pokemon.GetCurrentHp()}/{pokemon.GetMaxHp()}");
        }


        public void HealTeam()
        {
            if (ass_poke.Count == 0)
            {
                ConsoleUI.WriteCentered($"{Name} has no Pokémon to heal.");
                return;
            }

            ConsoleUI.WriteCentered($"{Name} is healing the whole team...");
            foreach (Pokemon p in ass_poke)
            {
                p.Heal();
                Console.WriteLine($"{p.Name}: {p.GetCurrentHp()}/{p.GetMaxHp()}");
            }
        }

        public void ClearTeam()
        {
            ass_poke.Clear();
        }

        public bool HasPokemon()
        {
            return ass_poke.Count > 0;
        }
    }
}
