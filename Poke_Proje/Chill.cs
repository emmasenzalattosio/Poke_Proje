using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class Chill : Pokemon, IHeal, IBattle
    {
        public Chill(string name, string owner, int level, int hp, int attack, int defense) : base(name, owner, level, hp, attack, defense) { }


        public override string Behavior()
        {
            return "Ich bin entspannt, aber nur weil ich meine Probleme sehr langsam angehe";
        }
    }
}
