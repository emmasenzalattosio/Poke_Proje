using System;

namespace Poke_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            static void Emoji()
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
            }
            Emoji();
            Arena arena = new Arena();

            NiceCute menu = new NiceCute(arena.Center, arena);
            menu.Start();


            Ascii ascii = new Ascii();

            ascii.Slaking();
        }
    }
}
