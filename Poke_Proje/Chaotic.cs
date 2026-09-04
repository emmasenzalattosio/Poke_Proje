using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class Chaotic : Pokemon, IBattle, IHeal
    {

        public Chaotic(string name, string trainer, int level, int hp, int attack, int defense) : base(name, trainer, level, hp, attack, defense) { }
    
        public override string Behavior()
        {
            return "Ich bringe Chaos rein wie ein Pokémon mit WLAN und keiner Anleitung";
        }


    }
}
