using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class NiceCute
    {
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

            int selected = 0;
            ConsoleKey Key;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to this beautiful PokeCenter");
                Console.WriteLine("What do we wanna do today sunshine??");
                Console.WriteLine();


                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selected)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" > {options[i]} ");
                        Console.ResetColor();
                    }

                    else
                    {
                        Console.WriteLine($" > {options[i]}");
                    }

                }

                Key = Console.ReadKey(true).Key;

                if (Key == ConsoleKey.UpArrow)
                {
                    selected--;

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


            PokemonCenter center = new PokemonCenter();

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
                            center.AddPokemon(chill);
                            break;
                        case '2':
                            Dramatic drama = new Dramatic(poke, "", 0, 0, 0, 0);
                            center.AddPokemon(drama);
                            break;
                        case '3':
                            Chaotic choas = new Chaotic(poke, "", 0, 0, 0, 0);
                            center.AddPokemon(choas);
                            break;
                        case '4':
                            Sneaky sssnake = new Sneaky(poke, "", 0, 0, 0, 0);
                            center.AddPokemon(sssnake);
                            break;

                        default:
                            Console.WriteLine("Invalid type");
                            break;
                    }


                    break;
                case 1:
                    center.ShowAllPokemon();
                    break;
                case 2:
                    Console.WriteLine("Enter the name of pokeon you looking for");
                    string name = Console.ReadLine()!;

                    center.SearchPokemon(name);

                    break;
                case 3:
                    center.ShowAllTrainers();
                    break;
                case 4:
                    

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
