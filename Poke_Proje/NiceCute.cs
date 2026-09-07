using System;
using System.Collections.Generic;
using System.Linq;

namespace Poke_Proje
{
    public class NiceCute
    {
        private readonly PokemonCenter Center;
        private readonly Arena Arena;

        public NiceCute(PokemonCenter center, Arena arena)
        {
            Center = center;
            Arena = arena;
        }

        public void Start()
        {
            Console.Clear();
            DrawBanner();

            Trainer? selectedTrainer = SelectTrainer();
            if (selectedTrainer == null)
            {
                return;
            }

            ShowActionMenu(selectedTrainer);
        }

        private Trainer? SelectTrainer()
        {
            List<Trainer> trainers = Center.GetAllTrainers();

            if (trainers.Count == 0)
            {
                Console.WriteLine("No trainers were found in the Pokemon Center.");
                Console.ReadKey(true);
                return null;
            }

            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();
                DrawBanner();
                Console.WriteLine("Choose your trainer:");
                Console.WriteLine();

                for (int i = 0; i < trainers.Count; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" > {trainers[i].Name} ({trainers[i].ass_poke.Count} Pokémon)");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"   {trainers[i].Name} ({trainers[i].ass_poke.Count} Pokémon)");
                    }
                }

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0)
                    {
                        selectedIndex = trainers.Count - 1;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= trainers.Count)
                    {
                        selectedIndex = 0;
                    }
                }
                else if (key == ConsoleKey.Enter)
                {
                    return trainers[selectedIndex];
                }
            }
        }

        private void ShowActionMenu(Trainer trainer)
        {
            string[] options =
            {
                "View Pokémon",
                "Search Pokémon",
                "Show Trainers",
                "Start Battle",
                "Heal Team",
                "Exit"
            };

            int selected = 0;

            while (true)
            {
                Console.Clear();
                DrawBanner();
                Console.WriteLine($"Trainer: {trainer.Name}");
                Console.WriteLine("====================================");
                Console.WriteLine();

                for (int i = 0; i < options.Length; i++)
                {
                    if (i == selected)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine($" > {options[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"   {options[i]}");
                    }
                }

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selected--;
                    if (selected < 0)
                    {
                        selected = options.Length - 1;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selected++;
                    if (selected >= options.Length)
                    {
                        selected = 0;
                    }
                }
                else if (key == ConsoleKey.Enter)
                {
                    switch (selected)
                    {
                        case 0:
                            trainer.ShowPokemon();
                            break;

                        case 1:
                            Console.Clear();
                            Console.WriteLine("Enter the name of the Pokémon you want to search:");
                            string searchName = Console.ReadLine() ?? string.Empty;
                            Center.SearchPokemon(searchName);
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.ReadKey(true);
                            break;

                        case 2:
                            Console.Clear();
                            Center.ShowAllTrainers();
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.ReadKey(true);
                            break;

                        case 3:
                            Arena.StartBattle(trainer);
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.ReadKey(true);
                            break;

                        case 4:
                            trainer.HealTeam();
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.ReadKey(true);
                            break;

                        case 5:
                            Console.Clear();
                            Console.WriteLine("Goodbye, trainer! See you at the next battle!");
                            Console.ReadKey(true);
                            return;
                    }
                }
            }
        }

        private static void DrawBanner()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("========================================");
            Console.WriteLine("   ____  _  _   ___  ____  ____  ___  ");
            Console.WriteLine("  / __ \\| || | / _ \\|  _ \\|  _ \\| _ \\ ");
            Console.WriteLine(" | |  | | || || | | | |_) | |_) | | | |");
            Console.WriteLine(" | |__| |__   | |_| |  __/|  __/| |_| |");
            Console.WriteLine("  \\____/   |_| \\___/|_|   |_|   \\___/ ");
            Console.WriteLine("========================================");
            Console.WriteLine("        POKE ARENA BATTLE CENTER");
            Console.WriteLine("========================================");
            Console.ResetColor();
        }
    }
}
