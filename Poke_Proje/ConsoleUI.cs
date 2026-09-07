using System;
using System.Collections.Generic;
using System.Linq;

namespace Poke_Proje
{
    public static class ConsoleUI
    {
        public static void WriteCentered(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine();
                return;
            }

            string[] lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            int maxWidth = lines.Max(line => line.Length);

            int leftPadding = Math.Max(0, (Console.WindowWidth - maxWidth) / 2);

            foreach (string line in lines)
            {
                Console.WriteLine(new string(' ', leftPadding) + line);
            }
        }

        public static void WriteCenteredHighlighted(string text, bool selected, int boxWidth = 30)
        {
            string display = selected ? $"> {text}" : $"  {text}";
            display = display.PadRight(boxWidth);

            int leftPadding = Math.Max(0, (Console.WindowWidth - boxWidth) / 2);

            Console.Write(new string(' ', leftPadding));

            if (selected)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }

            Console.Write(display);

            if (selected)
            {
                Console.ResetColor();
            }

            Console.WriteLine();
        }

        public static void DrawFrame(string title, IEnumerable<string> lines, ConsoleColor borderColor = ConsoleColor.Cyan, ConsoleColor titleColor = ConsoleColor.Yellow)
        {
            List<string> content = new List<string>();

            if (!string.IsNullOrWhiteSpace(title))
            {
                content.Add(title);
            }

            foreach (string line in lines)
            {
                if (line != null)
                {
                    content.Add(line);
                }
            }

            int width = Math.Max(36, content.Max(line => line.Length) + 2);
            int leftPadding = Math.Max(0, (Console.WindowWidth - width) / 2);

            Console.ForegroundColor = borderColor;
            Console.WriteLine(new string(' ', leftPadding) + "╔" + new string('═', width + 2) + "╗");
            Console.WriteLine(new string(' ', leftPadding) + "║" + new string(' ', width + 2) + "║");

            Console.ForegroundColor = titleColor;
            string titleLine = $" {title.Trim()} ";
            Console.WriteLine(new string(' ', leftPadding) + "║" + titleLine.PadRight(width + 1) + "║");

            Console.ForegroundColor = borderColor;
            Console.WriteLine(new string(' ', leftPadding) + "╠" + new string('═', width + 2) + "╣");
            Console.ResetColor();

            foreach (string line in content.Skip(!string.IsNullOrWhiteSpace(title) ? 1 : 0))
            {
                string display = line.Length > width ? line.Substring(0, width) : line.PadRight(width);
                Console.Write(new string(' ', leftPadding));
                Console.Write("║ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(display);
                Console.ResetColor();
                Console.WriteLine(" ║");
            }

            Console.ForegroundColor = borderColor;
            Console.WriteLine(new string(' ', leftPadding) + "╚" + new string('═', width + 2) + "╝");
            Console.ResetColor();
        }

        public static void WriteMenuFrame(string title, IEnumerable<string> items, int selectedIndex, ConsoleColor borderColor = ConsoleColor.DarkMagenta)
        {
            List<string> options = items.ToList();
            List<string> lines = new List<string>();

            for (int i = 0; i < options.Count; i++)
            {
                string prefix = i == selectedIndex ? "▶" : " ";
                lines.Add($"{prefix} {options[i]}");
            }

            DrawFrame(title, lines, borderColor, ConsoleColor.Yellow);
        }
    }
}
