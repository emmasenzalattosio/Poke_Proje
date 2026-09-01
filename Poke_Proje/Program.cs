namespace Poke_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PokemonCenter center = new PokemonCenter();

            Dramatic Jigglypuff = new Dramatic("Jiggly", "", 5, 6, 7, 8);
            center.AddPokemon(Jigglypuff);

            Trainer ash = new Trainer("Ash");
            center.AssignPokeon(Jigglypuff, ash);
            ash.ShowPokemon();

            center.ShowAllPokemon();

            center.GetBehavior(Jigglypuff);



        }
    }
}
