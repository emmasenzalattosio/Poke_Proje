using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class ListPoke 
    {

        public void AddPoke()
        {

            PokemonCenter center = new PokemonCenter();

            Dramatic Kosturso = new Dramatic("Kosturso", "Ash", 5, 6, 7, 8);
            center.AddPokemon(Kosturso);

            Dramatic Traumato = new Dramatic("Traumato", "", 4, 3, 3, 3);
            center.AddPokemon(Traumato);
            Dramatic Wheezing = new Dramatic("Galar Wheewing", "", 4, 3, 3, 3);
            center.AddPokemon(Wheezing);
            Dramatic Enamorus = new Dramatic("Enamorus", "", 4, 3, 3, 3);
            center.AddPokemon(Enamorus);
            Dramatic Scream = new Dramatic("Scream Tail", "", 4, 3, 3, 3);
            center.AddPokemon(Scream);
            Dramatic Mime = new Dramatic("Mr.Mime", "", 4, 3, 3, 3);
            center.AddPokemon(Mime);
            Dramatic Jigglypuff = new Dramatic("Jigglypuff", "", 4, 3, 3, 3);
            center.AddPokemon(Jigglypuff);


            Chill Snorlax = new Chill("Snorlax", "", 3, 4, 5, 6);
            center.AddPokemon(Snorlax);
            Chill Geowaz = new Chill("Alola Geowaz", "", 3, 4, 5, 6);
            center.AddPokemon(Geowaz);
            Chill Ghastly = new Chill("Ghastly", "", 3, 4, 5, 6);
            center.AddPokemon(Ghastly);
            Chill Probopass = new Chill("Probopass", "", 3, 4, 5, 6);
            center.AddPokemon(Probopass);
            Chill Squirtle = new Chill("Squirtle", "", 3, 4, 5, 6);
            center.AddPokemon(Squirtle);


            Sneaky Popplio = new Sneaky("Popplio", "", 3, 5, 6, 7);
            center.AddPokemon(Popplio);
            Sneaky Machoke = new Sneaky("Machoke", "", 3, 5, 6, 7);
            center.AddPokemon(Machoke);
            Sneaky Leafeon = new Sneaky("Leafeon", "", 3, 5, 6, 7);
            center.AddPokemon(Leafeon);
            Sneaky Meowth = new Sneaky("Meowth", "", 3, 5, 6, 7);
            center.AddPokemon(Meowth);
            Sneaky Arceus = new Sneaky("Arceus", "", 4, 5, 6, 7);
            center.AddPokemon(Arceus);


            Chaotic Pantifrost = new Chaotic("Pantifrost", "", 4, 5, 6, 7);
            center.AddPokemon(Pantifrost);
            Chaotic Bisasam = new Chaotic("Bisasam", "", 4, 5, 6, 7);
            center.AddPokemon(Bisasam);
            Chaotic Dugtrio = new Chaotic("Alolan Dugtrio", "", 4, 5, 6, 7);
            center.AddPokemon(Dugtrio);
            Chaotic Maboyystiff = new Chaotic("Maboyystiff", "", 4, 5, 6, 7);
            center.AddPokemon(Maboyystiff);
            Chaotic Swalot = new Chaotic("Swalot", "", 3, 4, 5, 6);
            center.AddPokemon(Swalot);







            Console.WriteLine();
            Trainer ash = new Trainer("Ash");
            center.AssignPokeon(Kosturso, ash);
            ash.ShowPokemon();

            Console.WriteLine();
            center.ShowAllPokemon();
            Console.WriteLine();

            center.GetBehavior(Kosturso);


        }

    }
}
