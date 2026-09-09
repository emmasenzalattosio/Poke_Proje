using System;
using System.Collections.Generic;

namespace Poke_Proje
{
    public class PokemonCenter
    {
        // stores all poke - trainer in center
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
            // left lines - buffer (instead of direct print)
            List<string> leftlines = new List<string>();
            leftlines.Add("Alle Trainer:");
            leftlines.Add("");

            // Loop through trainer - add header (name + numb pok)
            // pokeon name under
            foreach (Trainer t in trainerList)
            {
                leftlines.Add($"> {t.Name} ({t.ass_poke.Count} Pokémon)");
                for (int i = 0; i < t.ass_poke.Count; i++)
                {
                    leftlines.Add($"   - {t.ass_poke[i].Name}");
                }
                leftlines.Add("");
            }

            // take lines count and split two 
            // ceieling for odd counts so don´t lose a line
            int half = (int)Math.Ceiling(leftlines.Count / 2.0);
            List<string> col1 = leftlines.Take(half).ToList();
            List<string> col2 = leftlines.Skip(half).ToList();

            List<string> rightlines = @"
┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓
┃                        .:======-.                       ┃
┃                 +*********#********+.                   ┃
┃             :*#************************-                ┃
┃           *#*****#********#******-      .=              ┃
┃         %***********************-          #            ┃
┃       =#************#***********-           =+          ┃
┃      ************#********#******            *#         ┃
┃     +*****************************=          +**        ┃
┃    +***********#@%%%%%%@@************       +***+       ┃
┃   :#*********#%%%%*  =%%%%@*****#***************#-      ┃
┃   #*********%@%#  -  .. *%%%#***#*****#**********#      ┃
┃  .#*******#%@%# =      - @%%%%%%%%%%@@%#**********-     ┃
┃  =***#@@%%%%%%+          +%%%%%%%%%%%%%%%%%@@##***+     ┃
┃  #@@%%%%%%%%%%@ :      : @%%%%%%%%%%%%%%%%%%%%%%@@%     ┃
┃  *%%%%%%%%%@@%%@- .    .%%%%     -==-=#@@%%%%%%@@@%     ┃
┃  +%%%@*::     #%%%@%#@%%%@:               +**@@@@@*     ┃
┃   *             .*@@@@@=.                 :::::-+%:     ┃
┃   -                                      ::::::::+      ┃
┃   ..                                    ::::::::*:      ┃
┃    -.                                  ::::::::+-       ┃
┃     =                                :::::::::=+        ┃
┃      -+                            ::::::::::=+         ┃
┃        @:.                      .:::::::::::@           ┃
┃          @-::                ::::::::::::-%.            ┃
┃            %+-:::::::::::::::::::::::::=#.              ┃
┃              -#=-::::::::::::::::::-=#=                 ┃
┃                  =#*+===----====*#=                     ┃
┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛"
                .Split('\n')
                .Where(line => !string.IsNullOrWhiteSpace(line)) // optional: remove empty first line
                .ToList();

            ConsoleUI.WriteThreeColumns(col1, col2, rightlines, col1Width: 25, col2Width: 25, gap: 4, artOffset: 35);
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
