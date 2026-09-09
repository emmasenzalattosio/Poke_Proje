using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                ConsoleUI.WriteCentered("Es wurde kein Trainer im Pokemon Center gefunden.");
                Console.ReadKey(true);
                return null;
            }

            int selectedIndex = 0;

            while (true)
            {
                Console.Clear();
                DrawBanner();
                Console.ForegroundColor = ConsoleColor.Gray;
                ConsoleUI.WriteCentered(@"   ________                                                       __             _                
  / ____/ /_  ____  ____  ________     __  ______  __  _______   / /__________ _(_)___  ___  _____
 / /   / __ \/ __ \/ __ \/ ___/ _ \   / / / / __ \/ / / / ___/  / __/ ___/ __ `/ / __ \/ _ \/ ___/
/ /___/ / / / /_/ / /_/ (__  )  __/  / /_/ / /_/ / /_/ / /     / /_/ /  / /_/ / / / / /  __/ /    
\____/_/ /_/\____/\____/____/\___/   \__, /\____/\__,_/_/      \__/_/   \__,_/_/_/ /_/\___/_/     
                                    /____/                                                       ");
                Console.WriteLine();
                Console.ResetColor();


                for (int i = 0; i < trainers.Count; i++)
                {
                    ConsoleUI.WriteCenteredHighlighted($"│ 🙋🏻 {trainers[i].Name}                │", i == selectedIndex);
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
                "👀 Pokemon Anschauen",
                "🔍 Pokemon Suchen",
                "🧑‍🤝‍🧑 Trainer ANzeigen",
                "⚔️ Kämpfen",
                "💊 Team Heilen",
                "🕵️ Team WH's Hinterhalt",
                "🙋🏻 Neuen Trainer auswählen",
                "🚪 Verlassen"
            };
            

            int selected = 0;

            while (true)
            {
                Console.Clear();
                DrawBanner();
                Console.WriteLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                ConsoleUI.WriteCentered($"Trainer: {trainer.Name}");
                ConsoleUI.WriteCentered("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                Console.WriteLine();
                Console.ResetColor();

                for (int i = 0; i < options.Length; i++)
                {
                    ConsoleUI.WriteCenteredHighlighted($"{options[i]} ", i == selected);

                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                ConsoleUI.WriteCentered("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                Console.ResetColor();

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
                            ConsoleUI.WriteCentered("Gib den Namen des Pokemon's ein was du Suchst:");
                            string searchName = Console.ReadLine() ?? string.Empty;
                            Center.SearchPokemon(searchName);
                            ConsoleUI.WriteCentered("\nDrück eine Taste für weiter...");
                            Console.ReadKey(true);
                            break;

                        case 2:
                            Console.Clear();
                            Center.ShowAllTrainers();
                            ConsoleUI.WriteCentered("\nDrück eine Taste für weiter...");
                            Console.ReadKey(true);
                            break;

                        case 3:
                            Arena.StartBattle(trainer);
                            ConsoleUI.WriteCentered("\nDrück eine Taste für weiter...");
                            Console.ReadKey(true);
                            break;

                        case 4:
                            trainer.HealTeam();
                            ConsoleUI.WriteCentered("\nDrück eine Taste für weiter...");
                            Console.ReadKey(true);
                            break;

                        case 5:
                            Console.Clear();
                            Arena.RocketEncounter(trainer);
                            ConsoleUI.WriteCentered("\nDrück eine Taste für weiter...");
                            Console.ReadKey(true);

                            Arena arena = new Arena();
                            NiceCute menu = new NiceCute(arena.Center, arena);
                            menu.Start();
                            return;

                        case 6:
                            Console.Clear();

                            Trainer newTrainer = SelectTrainer();
                            ShowActionMenu(newTrainer);
                            return;

                        case 7:
                            Console.Clear();
                            ConsoleUI.WriteCentered("Auf Wiedersehen, trainer! Wir sehen uns beim nächsten Kampf!");
                            Console.ReadKey(true);
                            return;
                    }
                }
            }
        }


        private static void DrawBanner()
        {


            Console.ForegroundColor = ConsoleColor.White;
            ConsoleUI.WriteCentered(@"█▀▀▀▀▀▄   ▄▀▀▀▀▄  █▀▀█ ▀▀█  ▄▀▀▀▀▀█  ▄▀▀▀▀▄▄▀▀▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄ 
█      █ █      █ █  ▓   █ █      ▓ █          █ █      █ █      █
█  █▀  █ █  █▀  █ █   ▄▄▀  █  █▀▀▀▀ █  ░   ░   █ █  █▀  █ █  ░   █
▓  ▀▀ ▄▀ ▓  █▄  █ ▓  ▄  ▀▄ ▓  █▄█▄▄ ▓  ░   ░   █ ▓  █▄  █ ▓  ░   █
▒  █▀▀   ▒  ▀▀  ▒ ▒  █   ▒ ▒      ▒ ▒  ▒   ▒   ▓ ▒  ▀▀  ▒ ▒  ▒   ▓
░▄▄█      ▀▄▄▄▄▀  ░▄▄█ ▄▄░  ▀▄▄▄▄▄█ ▒▄▄▓ ▄▄▓ ▄▄▒  ▀▄▄▄▄▀  ▒▄▄▓ ▄▄▒");

            Console.ResetColor();
        }


    }
}
