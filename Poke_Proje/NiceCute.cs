using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class NiceCute
    {
        private PokemonCenter Center;
        public NiceCute(PokemonCenter center)
        {
            Center = center;
        }

        public void ShowStart()
        {


            string[] options = new string[]
            {
                "Catch Poke",
                "ShowPoke",
                "SearchPoke",
                "Show Trainer",
                "StartWar",
                "HealPoke"
            };

            int selected = 0; //index of first string
            ConsoleKey Key; //stores the key user press

            // do while because we need it to run at least once before condition met
            // loop keep going till user press enter
            //menu needs to be seen at least once
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to this beautiful PokeCenter");
                Console.WriteLine("What do we wanna do today sunshine??");
                Console.WriteLine();

                // printing option with highlight
                for (int i = 0; i < options.Length; i++)
                {
                    // if my i is the current one I´m laying on then BOOM hockus pockus change color 
                    if (i == selected)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" > {options[i]} ");
                        Console.ResetColor();
                    }

                    // if not then normal color
                    else
                    {
                        Console.WriteLine($" > {options[i]}");
                    }

                }

                // User press key and true makes sure it´s not seen on screen
                Key = Console.ReadKey(true).Key;

                // presso arrow up then decrease select by 1 
                if (Key == ConsoleKey.UpArrow)
                {
                    selected--;

                    // last position but still keep clicking?? GGRRR
                    // this makes sure it goes all around
                    if (selected < 0)
                    {
                        selected = options.Length - 1;
                    }
                }

                else if (Key == ConsoleKey.DownArrow)
                {
                    selected++;
                    if (selected > options.Length - 1)
                    {
                        selected = 0;
                    }
                }

            }
            while (Key != ConsoleKey.Enter);
            // if enter pressed then gg loop can stop!! 



            switch (selected)
            {
                case 0:
                    Console.WriteLine(" -- Choose the type: -- ");
                    Console.WriteLine("    [1] Chill");
                    Console.WriteLine("    [2] Dramatic");
                    Console.WriteLine("    [3] Chaotic");
                    Console.WriteLine("    [4] Sneaky");

                    char cate = Console.ReadKey().KeyChar;


                    Console.WriteLine("What pokemon would you like to add??");
                    string poke = Console.ReadLine()!;

                    switch (cate)
                    {
                        case '1':
                            Chill chill = new Chill(poke, "", 0, 0, 0, 0);
                            Center.AddPokemon(chill);
                            break;
                        case '2':
                            Dramatic drama = new Dramatic(poke, "", 0, 0, 0, 0);
                            Center.AddPokemon(drama);
                            break;
                        case '3':
                            Chaotic choas = new Chaotic(poke, "", 0, 0, 0, 0);
                            Center.AddPokemon(choas);
                            break;
                        case '4':
                            Sneaky sssnake = new Sneaky(poke, "", 0, 0, 0, 0);
                            Center.AddPokemon(sssnake);
                            break;

                        default:
                            Console.WriteLine("Invalid type");
                            break;
                    }


                    break;
                case 1:
                    Center.ShowAllPokemon();
                    break;
                case 2:
                    Console.WriteLine("Enter the name of pokeon you looking for");
                    string name = Console.ReadLine()!;

                    Center.SearchPokemon(name);

                    break;
                case 3:
                    Center.ShowAllTrainers();
                    break;
                case 4:
                    Arena arena = new Arena();
                    arena.StartBattle();

                    break;
                case 5:
                    Console.WriteLine("What pokemon yould you like to heal??");
                    string heal_poke = Console.ReadLine()!;

                    //center.HealPokemon(heal_poke);
                    break;



            }

        }

    }
}
