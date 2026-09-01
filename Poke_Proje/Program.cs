namespace Poke_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Arena arena = new Arena();

            NiceCute menu = new NiceCute(arena.Center);
            menu.ShowStart();

        }
    }
}
