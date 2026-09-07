using System;
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
    }
}