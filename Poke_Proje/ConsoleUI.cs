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

        public static void WriteThreeColumns(
       List<string> col1Lines,
       List<string> col2Lines,
       List<string> col3Lines,
       int col1Width = 35,
       int col2Width = 35,
       int gap = 4,
       int leftPad = 2,
       int artOffset = 0)
        {
            int rowCount = Math.Max(col1Lines.Count, Math.Max(col2Lines.Count, col3Lines.Count));

            for (int i = 0; i < rowCount; i++)
            {
                string c1 = i < col1Lines.Count ? col1Lines[i] : "";
                string c2 = i < col2Lines.Count ? col2Lines[i] : "";
                string c3 = i < col3Lines.Count ? col3Lines[i] : "";

                c1 = c1.Length > col1Width ? c1.Substring(0, col1Width) : c1.PadRight(col1Width);
                c2 = c2.Length > col2Width ? c2.Substring(0, col2Width) : c2.PadRight(col2Width);

                string line =
                    new string(' ', leftPad) +
                    c1 +
                    new string(' ', gap) +
                    c2 +
                    new string(' ', gap) +
                    new string(' ', artOffset) + 
                    c3;

                Console.WriteLine(line);
            }
        }
    }
}

