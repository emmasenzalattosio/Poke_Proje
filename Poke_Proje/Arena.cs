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
          
            Trainer holger = new Trainer("Holger");
            Trainer aman = new Trainer("Aman");
            Trainer hasan = new Trainer("Hasan");
            Trainer jens = new Trainer("Jens");
            Trainer chris = new Trainer("Chris");
            Trainer vanessa = new Trainer("Vanessa");
            Trainer emma = new Trainer("Emma");
            Trainer josi = new Trainer("Josi");
            Trainer babak = new Trainer("Babak");
            Trainer mohammed = new Trainer("Mohammed");
            Trainer ilia = new Trainer("Ilia");
            Trainer sasha = new Trainer("Sasha");
            Trainer raffael = new Trainer("Raffael");
            Trainer fabian = new Trainer("Fabian");
            Trainer kathy = new Trainer("Kathy");
            Trainer azzeddine = new Trainer("Azzeddine");
            Trainer daniel = new Trainer("Daniel");
            Trainer marcel = new Trainer("Marcel");
            Trainer roman = new Trainer("Roman");
            Trainer felix = new Trainer("Felix");
            Trainer daniel2 = new Trainer("Daniel2");
            Trainer sven = new Trainer("Sven");
            Trainer aikut = new Trainer("Aykut");



            //level, HP, Attack, Defense

            Dramatic Kosturso = new Dramatic("Kosturso", "Ash", 50, 110, 40, 80);
            Kosturso.AddAttack("Dramatischer hieb", 35);
            Kosturso.AddAttack("Josi hating", 15);
            Kosturso.AddAttack("Big foot attack", 40);
            Kosturso.AddAttack("Tonsur-Reflektor", 50);
            Center.AddPokemon(Kosturso);
            jens.AssignPokemon(Kosturso);

            Dramatic Traumato = new Dramatic("Traumato", "Brock", 45, 70, 50, 40);
            Traumato.AddAttack("Dramatische Rede", 8);
            Center.AddPokemon(Traumato);
            mohammed.AssignPokemon(Traumato);

            Dramatic Wheezing = new Dramatic("Galar Wheewing", "", 64, 100, 60, 65);
            Center.AddPokemon(Wheezing);
            holger.AssignPokemon(Wheezing);

            Dramatic Enamorus = new Dramatic("Enamorus", "", 33, 70, 40, 80);
            Center.AddPokemon(Enamorus);
            fabian.AssignPokemon(Enamorus);

            Dramatic Screamtail = new Dramatic("Scream Tail", "", 29, 60, 20, 40);
            Center.AddPokemon(Screamtail);
            marcel.AssignPokemon(Screamtail); fdgv

            Dramatic Mime = new Dramatic("Mr.Mime", "", 37, 90, 70, 35);
            Center.AddPokemon(Mime);
            felix.AssignPokemon(Mime);

            Dramatic Jigglypuff = new Dramatic("Jigglypuff", "", 67, 67, 67, 67);
            Center.AddPokemon(Jigglypuff);
            emma.AssignPokemon(Jigglypuff);


            Chill Snorlax = new Chill("Snorlax", "", 3, 4, 5, 6);
            Center.AddPokemon(Snorlax);
            hasan.AssignPokemon(Snorlax);

            Chill Slaking = new Chill("Slaking", "", 3, 4, 5, 6);
            Center.AddPokemon(Slaking);
            babak.AssignPokemon(Slaking);

            Chill Ghastly = new Chill("Ghastly", "", 3, 4, 5, 6);
            Center.AddPokemon(Ghastly);
            sven.AssignPokemon(Ghastly);

            Chill Probopass = new Chill("Probopass", "", 3, 4, 5, 6);
            Center.AddPokemon(Probopass);
            raffael.AssignPokemon(Probopass);

            Chill Squirtle = new Chill("Squirtle", "", 3, 4, 5, 6);
            Center.AddPokemon(Squirtle);
            roman.AssignPokemon(Squirtle);



            Sneaky Popplio = new Sneaky("Popplio", "", 3, 5, 6, 7);
            Center.AddPokemon(Popplio);
            ilia.AssignPokemon(Popplio);

            Sneaky Machamp = new Sneaky("Machoke", "", 3, 5, 6, 7);
            Center.AddPokemon(Machamp);
            sasha.AssignPokemon(Machamp);

            Sneaky Leafeon = new Sneaky("Leafeon", "", 3, 5, 6, 7);
            Center.AddPokemon(Leafeon);
            kathy.AssignPokemon(Leafeon);

            Sneaky Meowth = new Sneaky("Meowth", "", 3, 5, 6, 7);
            Center.AddPokemon(Meowth);
            azzeddine.AssignPokemon(Meowth);

            Sneaky Arceus = new Sneaky("Arceus", "", 4, 5, 6, 7);
            Center.AddPokemon(Arceus);
            aikut.AssignPokemon(Arceus);


            Chaotic Pantifrost = new Chaotic("Pantifrost", "", 4, 5, 6, 7);
            Center.AddPokemon(Pantifrost);
            chris.AssignPokemon(Pantifrost);

            Chaotic Bisasam = new Chaotic("Bisasam", "", 4, 5, 6, 7);
            Center.AddPokemon(Bisasam);
            vanessa.AssignPokemon(Bisasam);

            Chaotic Dugtrio = new Chaotic("Alolan Dugtrio", "", 4, 5, 6, 7);
            Center.AddPokemon(Dugtrio);
            josi.AssignPokemon(Dugtrio);

            Chaotic Maboyystiff = new Chaotic("Maboyystiff", "", 4, 5, 6, 7);
            Center.AddPokemon(Maboyystiff);
            daniel.AssignPokemon(Maboyystiff);

            Chaotic Swalot = new Chaotic("Swalot", "", 3, 4, 5, 6);
            Center.AddPokemon(Swalot);
            aman.AssignPokemon(Swalot);


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
