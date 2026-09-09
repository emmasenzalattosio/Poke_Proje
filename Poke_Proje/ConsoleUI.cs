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

        public static void WriteCenteredScreen(string title, IEnumerable<string> lines, ConsoleColor titleColor = ConsoleColor.Yellow)
        {
            List<string> body = lines.Select(line => line ?? string.Empty).ToList();

            bool hasTitle = !string.IsNullOrWhiteSpace(title);
            string trimmedTitle = hasTitle ? title.Trim() : string.Empty;

            // Every line (title included) shares ONE left padding, computed from the widest
            // line in the whole block. This keeps emoji/bullets in the same column instead
            // of each line being centered on its own (which shifts them row by row).
            int maxWidth = body.Count > 0 ? body.Max(line => line.Length) : 0;
            if (hasTitle)
            {
                maxWidth = Math.Max(maxWidth, trimmedTitle.Length);
            }

            int leftPadding = Math.Max(0, (Console.WindowWidth - maxWidth) / 2);
            string pad = new string(' ', leftPadding);

            if (hasTitle)
            {
                Console.ForegroundColor = titleColor;
                Console.WriteLine(pad + trimmedTitle);
                Console.ResetColor();
                Console.WriteLine();
            }

            foreach (string line in body)
            {
                Console.WriteLine(pad + line);
            }
        }

        public static void WriteTwoColumns(
        List<string> leftLines,
        List<string> rightLines,
        int leftWidth = 40,
        int gap = 4,
        int leftPad = 2,
        int rightPad = 0)
        {
            int rowCount = Math.Max(leftLines.Count, rightLines.Count);

            for (int i = 0; i < rowCount; i++)
            {
                string left = i < leftLines.Count ? leftLines[i] : "";
                string right = i < rightLines.Count ? rightLines[i] : "";

                // Truncate or pad the left column so the right one always lines up
                if (left.Length > leftWidth)
                    left = left.Substring(0, leftWidth);
                else
                    left = left.PadRight(leftWidth);

                string line =
                    new string(' ', leftPad) +
                    left +
                    new string(' ', gap) +
                    new string(' ', rightPad) +
                    right;

                Console.WriteLine(line);
            }
        }
    }
}
