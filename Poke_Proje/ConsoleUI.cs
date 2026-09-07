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

        //public static void DrawFrame(int width, ConsoleColor color)
        //{
        //    Console.ForegroundColor = color;
        //    Console.WriteLine("╔" + new string('═', width - 2) + "╗");
        //    Console.ResetColor();
        //}

        //public static void DrawBottomFrame(int width, ConsoleColor color)
        //{
        //    Console.ForegroundColor = color;
        //    Console.WriteLine("╚" + new string('═', width - 2) + "╝");
        //    Console.ResetColor();
        //}

        public static void DrawCenteredFrameWithTitle(string title, int width, ConsoleColor color)
        {
            int leftPadding = Math.Max(0, (Console.WindowWidth - width) / 2);
            string pad = new string(' ', leftPadding);

            Console.ForegroundColor = color;
            Console.WriteLine(pad + "╔" + new string('═', width - 2) + "╗");

            string centeredTitle = title.PadLeft((width - 2 + title.Length) / 2).PadRight(width - 2);
            Console.WriteLine(pad + "║" + centeredTitle + "║");

            Console.WriteLine(pad + "╚" + new string('═', width - 2) + "╝");
            Console.ResetColor();
        }

    }
}