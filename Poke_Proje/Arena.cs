using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class Arena
    {
        public PokemonCenter Center { get; private set; }
        private Random random = new Random();

        public Arena()
        {

            Center = new PokemonCenter();
          
            Trainer ash = new Trainer("Ash");
            Trainer gogo = new Trainer("Gogo");
            Trainer shit = new Trainer("Shit");
            Trainer suckdick = new Trainer("Suck Dick");

            Dramatic Kosturso = new Dramatic("Kosturso", "Ash", 50, 110, 11, 8);
            Kosturso.AddAttack("Cacca pupu", 8);
            Center.AddPokemon(Kosturso);
            ash.AssignPokemon(Kosturso);

            Dramatic Traumato = new Dramatic("Traumato", "Brock", 4, 3, 3, 3);
            Center.AddPokemon(Traumato);
            ash.AssignPokemon(Traumato);

            Dramatic Wheezing = new Dramatic("Galar Wheewing", "", 4, 3, 3, 3);
            Dramatic Enamorus = new Dramatic("Enamorus", "", 4, 3, 3, 3);
            Dramatic Scream = new Dramatic("Scream Tail", "", 4, 3, 3, 3);
            Dramatic Mime = new Dramatic("Mr.Mime", "", 4, 3, 3, 3);
            Dramatic Jigglypuff = new Dramatic("Jigglypuff", "", 4, 3, 3, 3);


            Chill Snorlax = new Chill("Snorlax", "", 3, 4, 5, 6);
            Chill Geowaz = new Chill("Alola Geowaz", "", 3, 4, 5, 6);
            Chill Ghastly = new Chill("Ghastly", "", 3, 4, 5, 6);
            Chill Probopass = new Chill("Probopass", "", 3, 4, 5, 6);
            Chill Squirtle = new Chill("Squirtle", "", 3, 4, 5, 6);


            Sneaky Popplio = new Sneaky("Popplio", "", 3, 5, 6, 7);
            Sneaky Machoke = new Sneaky("Machoke", "", 3, 5, 6, 7);
            Sneaky Leafeon = new Sneaky("Leafeon", "", 3, 5, 6, 7);
            Sneaky Meowth = new Sneaky("Meowth", "", 3, 5, 6, 7);
            Sneaky Arceus = new Sneaky("Arceus", "", 4, 5, 6, 7);


            Chaotic Pantifrost = new Chaotic("Pantifrost", "", 4, 5, 6, 7);
            Chaotic Bisasam = new Chaotic("Bisasam", "", 4, 5, 6, 7);
            Chaotic Dugtrio = new Chaotic("Alolan Dugtrio", "", 4, 5, 6, 7);
            Chaotic Maboyystiff = new Chaotic("Maboyystiff", "", 4, 5, 6, 7);
            Chaotic Swalot = new Chaotic("Swalot", "", 3, 4, 5, 6);


        }

        //Loop that keeps going till the stupid user inserts a valid numb
        private int ReadNumber(int min, int max)
        {
            int result; // variable to store number inserted

            while (true)
            {
                Console.Write($"Enter a number ({min}-{max}): ");
                // Parse - converts text in numb (stores 3 in result and gets true)
                // Checks if number is between range 
                if (int.TryParse(Console.ReadLine(), out result) && result >= min && result <= max)
                    return result; // stops the loop in case eingabe = good

                Console.WriteLine("Invalid, try again.");
            }
        }

        public void StartBattle()
        {
            List<Pokemon> all = Center.GetAllPokeon();

            Console.WriteLine("Choose your pokeon biatch!!");
            for (int i = 0; i < all.Count; i++)
            {
                Console.WriteLine($"{i + 1} {all[i].Name}");
            }

            //Calling the chosenumb method and goes through all the pokeon list counting
            //So in ausgabe gonna count all the available 
            // - 1 because list (like arrays) start from pos 0
            Pokemon pokeon = all[ReadNumber(1, all.Count) - 1];

            Console.WriteLine("Choose pokeon you wanna fight ass");
            for (int i = 0; i < all.Count; i++)
            {
                Console.WriteLine($"{i + 1} {all[i].Name}");

            }

            Pokemon enemy_pokeon = all[ReadNumber(1, all.Count) - 1];
            Console.WriteLine($"\n{pokeon.Name} VS {enemy_pokeon.Name}!\n");

            Fight(pokeon, enemy_pokeon);

        }


        private void Fight(Pokemon me, Pokemon enemy)
        {
            while (!me.IsDefeated() && !enemy.IsDefeated())
            {
                Console.WriteLine($"{me.Name} availoble attacko:");
                for (int i = 0; i < me.attacks.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {me.attacks[i].Name} {me.attacks[i].Damage}");
                }

                Attack mine = me.attacks[ReadNumber(1, me.attacks.Count) - 1];
                enemy.TakeDamage(me.Attack(enemy, mine));
            }

            if (enemy.IsDefeated())
            {
                Console.WriteLine($"{enemy.Name} died gg brosky {me.Name} wins!!");
                return;
            }

            Attack other = enemy.attacks[random.Next(enemy.attacks.Count) - 1];
            me.TakeDamage(enemy.Attack(me, other));

            if (me.IsDefeated())
            {
                Console.WriteLine($"YOOO YOU KILLED MEEE BITCHHH - {enemy.Name} wins >:c");
            }


        }

    }
}
