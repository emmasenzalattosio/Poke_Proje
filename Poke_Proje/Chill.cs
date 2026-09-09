using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class Chill : Pokemon, IHeal, IBattle
    {
        public Chill(string name, string trainer, int level, int hp, int attack) : base(name, trainer, level, hp, attack) { }


        public override string Behavior()
        {
            Console.WriteLine();
            return "Ich bin entspannt, aber nur weil ich meine Probleme sehr langsam angehe";
        }
    }
}
