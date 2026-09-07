using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Proje
{
    public static class ConsoleUI
    {
        public static void WriteCentered(string text)
        {
            int leftPadding = Math.Max(0, (Console.WindowWidth - text.Length) / 2);
            Console.WriteLine(new string(' ', leftPadding) + text);
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